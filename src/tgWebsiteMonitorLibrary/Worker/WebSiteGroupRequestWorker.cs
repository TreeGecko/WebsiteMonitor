using System;
using System.Net;
using System.Threading;
using TreeGecko.Library.Common.Delegates;
using TreeGecko.Library.Common.Interfaces;
using TreeGecko.WebMonitor.Library.Constants;
using TreeGecko.WebMonitor.Library.Manager;
using TreeGecko.WebMonitor.Library.Objects;

namespace TreeGecko.WebMonitor.Library.Worker
{
    public class WebSiteGroupRequestWorker : IWorker
    {
        Thread m_Thread;
        private readonly WebSite m_Site;
        private readonly WebsiteMonitorManager m_Manager;

        public WebSiteGroupRequestWorker(WebsiteMonitorManager _manager,
            WebSite _site)
        {
            m_Site = _site;
            m_Manager = _manager;
        }

        public void Start()
        {
            m_Thread = new Thread(DoWork);
            m_Thread.Start();
        }

        public void Stop()
        {
            
        }

        private void DoWork()
        {
            WebSiteCheck webSiteCheck = new WebSiteCheck
            {
                Active = true,
                CheckDateTime = DateTime.UtcNow,
                ParentGuid = m_Site.Guid
            };

            long startTicks = DateTime.UtcNow.Ticks;

            try
            {
                WebRequest request = WebRequest.Create(m_Site.Url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                webSiteCheck.StatusCode = response.StatusCode.ToString();
                long endTicks = DateTime.UtcNow.Ticks;

                webSiteCheck.ResponseTime = Convert.ToDouble((endTicks - startTicks) / 1000);
            }
            catch (Exception ex)
            {
                webSiteCheck.Result = Results.Failure;
                webSiteCheck.ErrorMessage = ex.ToString();
            }

            m_Manager.Persist(webSiteCheck);
        }

        public event WorkCompleteHandler WorkComplete;
    }
}
