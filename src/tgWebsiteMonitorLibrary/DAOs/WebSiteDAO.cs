using MongoDB.Driver;
using TreeGecko.Library.Mongo.DAOs;
using TreeGecko.WebMonitor.Library.Objects;

namespace TreeGecko.WebMonitor.Library.DAOs
{
    internal class WebSiteDAO : AbstractMongoDAO<WebSite>
    {
        public WebSiteDAO(MongoDatabase _mongoDB) :
            base(_mongoDB)
        {
            HasParent = false;
        }

        public override string TableName
        {
            get { return "WebSites"; }
        }
    }
}
