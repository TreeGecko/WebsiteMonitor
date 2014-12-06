using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using TreeGecko.Library.Common.Helpers;
using TreeGecko.Library.Mongo.DAOs;
using TreeGecko.WebMonitor.Library.Objects;

namespace TreeGecko.WebMonitor.Library.DAOs
{
    internal class WebSiteCheckDAO : AbstractMongoDAO<WebSiteCheck>
    {
        public WebSiteCheckDAO(MongoDatabase _mongoDB) 
            : base(_mongoDB)
        {
        }

        public override string TableName
        {
            get { return "SiteChecks"; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_siteGuid"></param>
        /// <returns></returns>
        public List<WebSiteCheck> GetWebSiteChecks(Guid _siteGuid)
        {
            IMongoQuery query = GetQuery("ParentGuid", _siteGuid.ToString());
            MongoCursor cursor = GetCursor(query).SetSortOrder(SortBy.Ascending("CheckDateTime"));
            return GetList(cursor);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_siteGuid"></param>
        /// <param name="_startDateTime"></param>
        /// <param name="_endDateTime"></param>
        /// <returns></returns>
        public List<WebSiteCheck> GetWebSiteChecks(Guid _siteGuid,
            DateTime _startDateTime, DateTime _endDateTime)
        {
            IMongoQuery query = Query.And(Query.EQ("ParentGuid", _siteGuid),
                Query.GTE("StartDateTime", DateHelper.ToString(_startDateTime)),
                Query.LTE("EndDateTime", DateHelper.ToString(_endDateTime)));
            
            MongoCursor cursor = GetCursor(query).SetSortOrder(SortBy.Ascending("CheckDateTime"));
            return GetList(cursor);
        }
    }
}
