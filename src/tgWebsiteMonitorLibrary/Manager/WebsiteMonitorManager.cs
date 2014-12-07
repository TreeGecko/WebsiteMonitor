using System;
using System.Collections.Generic;
using TreeGecko.Library.Mongo.Managers;
using TreeGecko.WebMonitor.Library.DAOs;
using TreeGecko.WebMonitor.Library.Objects;

namespace TreeGecko.WebMonitor.Library.Manager
{
    public class WebsiteMonitorManager : AbstractMongoManager
    {
        public WebsiteMonitorManager() 
            : base("WSM")
        {

        }

        #region User
        public void Persist(User _user)
        {
            UserDAO dao = new UserDAO(MongoDB);
            dao.Persist(_user);
        }

        public User GetUser(Guid _userGuid)
        {
            UserDAO dao = new UserDAO(MongoDB);
            return dao.Get(_userGuid);
        }

        public User GetUser(string _username)
        {
            UserDAO dao = new UserDAO(MongoDB);
            return dao.GetOneItem<User>("Username", _username);
        }
        #endregion

        #region WebSite

        public void Persist(WebSite _site)
        {
            WebSiteDAO dao = new WebSiteDAO(MongoDB);
            dao.Persist(_site);
        }

        public WebSite GetWebSite(Guid _siteGuid)
        {
            WebSiteDAO dao = new WebSiteDAO(MongoDB);
            return dao.Get(_siteGuid);
        }

        public List<WebSite> GetWebSites()
        {
            WebSiteDAO dao = new WebSiteDAO(MongoDB);
            return dao.GetAll();
        }

        #endregion

        #region WebSiteCheck

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_webSiteCheck"></param>
        public void Persist(WebSiteCheck _webSiteCheck)
        {
            WebSiteCheckDAO dao = new WebSiteCheckDAO(MongoDB);
            dao.Persist(_webSiteCheck);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_webSiteCheckGuid"></param>
        /// <returns></returns>
        public WebSiteCheck GetWebSiteCheck(Guid _webSiteCheckGuid)
        {
            WebSiteCheckDAO dao = new WebSiteCheckDAO(MongoDB);
            return dao.Get(_webSiteCheckGuid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_webSiteGuid"></param>
        /// <returns></returns>
        public List<WebSiteCheck> GetWebSiteChecks(Guid _webSiteGuid)
        {
            WebSiteCheckDAO dao = new WebSiteCheckDAO(MongoDB);
            return dao.GetWebSiteChecks(_webSiteGuid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_webSiteGuid"></param>
        /// <param name="_startDateTime"></param>
        /// <param name="_endDateTime"></param>
        /// <returns></returns>
        public List<WebSiteCheck> GetWebSiteChecks(Guid _webSiteGuid,
            DateTime _startDateTime, DateTime _endDateTime)
        {
            WebSiteCheckDAO dao = new WebSiteCheckDAO(MongoDB);
            return dao.GetWebSiteChecks(_webSiteGuid, _startDateTime, _endDateTime);
        }

        #endregion

        #region Alert

        public void Persist(Alert _alert)
        {
            AlertDAO dao = new AlertDAO(MongoDB);
            dao.Persist(_alert);
        }

        public Alert GetAlert(Guid _alertGuid)
        {
            AlertDAO dao = new AlertDAO(MongoDB);
            return dao.Get(_alertGuid);
        }

        public List<Alert> GetAlerts(Guid _siteGuid)
        {
            return null;
        }

        #endregion

        #region WebSiteGroup

        public void Persist(WebSiteGroup _webSiteGroup)
        {
            WebSiteGroupDAO dao = new WebSiteGroupDAO(MongoDB);
            dao.Persist(_webSiteGroup);
        }

        public WebSiteGroup GetWebSiteGroup(Guid _websiteGroupGuid)
        {
            WebSiteGroupDAO dao = new WebSiteGroupDAO(MongoDB);
            return dao.Get(_websiteGroupGuid);
        }

        #endregion

    }
}
