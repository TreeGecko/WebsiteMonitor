using TreeGecko.Library.Mongo.Managers;
using TreeGecko.WebMonitor.Library.DAOs;

namespace TreeGecko.WebMonitor.Library.Manager
{
    public class WebsiteMonitorStructureManager
        : AbstractMongoManager
    {
        public WebsiteMonitorStructureManager() 
            : base("WM")
        {
            WebSiteCheckDAO siteCheckDAO = new WebSiteCheckDAO(MongoDB);
            siteCheckDAO.BuildTable();

            WebSiteDAO siteDAO = new WebSiteDAO(MongoDB);
            siteDAO.BuildTable();

            UserDAO userDAO = new UserDAO(MongoDB);
            userDAO.BuildTable();

        }
    }
}
