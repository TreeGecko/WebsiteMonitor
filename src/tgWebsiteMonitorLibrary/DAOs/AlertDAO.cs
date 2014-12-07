using System;
using System.Collections.Generic;
using MongoDB.Driver;
using TreeGecko.Library.Mongo.DAOs;
using TreeGecko.WebMonitor.Library.Objects;

namespace TreeGecko.WebMonitor.Library.DAOs
{
    internal class AlertDAO
        : AbstractMongoDAO<Alert>
    {
        public AlertDAO(MongoDatabase _mongoDB) :
            base(_mongoDB)
        {
            //Either a WebSite or WebSiteGroup
            HasParent = true;

        }

        public override string TableName
        {
            get { return "Alerts"; }
        }

        /// <summary>
        /// Returns all alerts for a site or group.  Don't use as this could get long.
        /// </summary>
        /// <param name="_parentGuid"></param>
        /// <returns></returns>
        public List<Alert> GetAlerts(Guid _parentGuid)
        {
            return null;
        }

        /// <summary>
        /// Returns all current alerts
        /// </summary>
        /// <returns></returns>
        public List<Alert> GetCurrentAlerts()
        {
            return null;
        }

        /// <summary>
        /// Returns all alerts between time period
        /// </summary>
        /// <param name="_startDateTime"></param>
        /// <param name="_endDateTime"></param>
        /// <returns></returns>
        public List<Alert> GetAlerts(DateTime _startDateTime, DateTime _endDateTime)
        {
            return null;
        }

        /// <summary>
        /// Returns alerts between time period for specific site or group
        /// </summary>
        /// <param name="_parentGuid"></param>
        /// <param name="_startDateTime"></param>
        /// <param name="_endDateTime"></param>
        /// <returns></returns>
        public List<Alert> GetAlerts(Guid _parentGuid, DateTime _startDateTime, DateTime _endDateTime)
        {
            return null;
        }

    }
}
