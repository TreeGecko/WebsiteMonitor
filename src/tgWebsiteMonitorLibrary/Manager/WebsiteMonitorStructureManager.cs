using TreeGecko.Library.Mongo.Managers;
using TreeGecko.WebMonitor.Library.DAOs;

namespace TreeGecko.WebMonitor.Library.Manager
{
    public class WebsiteMonitorStructureManager
        : AbstractMongoManager
    {
        public WebsiteMonitorStructureManager()
            : base("WSM")
        {
        }

        public void BuildDB()
        {
            WebSiteCheckDAO siteCheckDAO = new WebSiteCheckDAO(MongoDB);
            siteCheckDAO.BuildTable();

            WebSiteDAO siteDAO = new WebSiteDAO(MongoDB);
            siteDAO.BuildTable();

            UserDAO userDAO = new UserDAO(MongoDB);
            userDAO.BuildTable();

            WebSiteGroupDAO webSiteGroupDAO = new WebSiteGroupDAO(MongoDB);
            webSiteGroupDAO.BuildTable();

            AlertDAO alertDAO = new AlertDAO(MongoDB);
            alertDAO.BuildTable();
        }
    }
}
