using MongoDB.Driver;
using TreeGecko.Library.Mongo.DAOs;
using TreeGecko.WebMonitor.Library.Objects;

namespace TreeGecko.WebMonitor.Library.DAOs
{
    internal class UserDAO 
        : AbstractMongoDAO<User>
    {
        public UserDAO(MongoDatabase _mongoDB) :
            base(_mongoDB)
        {
            HasParent = false;
        }

        public override string TableName
        {
            get { return "Users"; }
        }

        public override void BuildTable()
        {
            base.BuildTable();

            BuildUniqueIndex("Username", "USERNAME");
        }
    }
}
