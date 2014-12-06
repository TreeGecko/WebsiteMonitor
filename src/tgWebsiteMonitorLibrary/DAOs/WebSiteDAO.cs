using MongoDB.Driver;
using TreeGecko.Library.Mongo.DAOs;
using TreeGecko.WebMonitor.Library.Objects;

namespace TreeGecko.WebMonitor.Library.DAOs
{
    public class WebSiteDAO : AbstractMongoDAO<WebSite>
    {
        public WebSiteDAO(MongoDatabase _mongoDB) :
            base(_mongoDB)
        {
            
        }

        public override string TableName
        {
            get { return "Sites"; }
        }
    }
}
