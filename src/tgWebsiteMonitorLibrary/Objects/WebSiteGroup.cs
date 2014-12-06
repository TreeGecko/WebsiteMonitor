using System;
using System.Collections.Generic;
using TreeGecko.Library.Common.Objects;

namespace TreeGecko.WebMonitor.Library.Objects
{
    public class WebSiteGroup : AbstractTGObject
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Seconds to check web site.
        /// </summary>
        public int CheckEvery { get; set; }

        /// <summary>
        /// Next time to test the web site.
        /// </summary>
        public DateTime NextCheckTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Guid> UsersToNotify { get; set; } 

        public override TGSerializedObject GetTGSerializedObject()
        {
            TGSerializedObject tgs = base.GetTGSerializedObject();

            tgs.Add("Name", Name);
            tgs.Add("Description", Description);
            tgs.Add("CheckEvery", CheckEvery);
            tgs.Add("NextCheckTime", NextCheckTime);
            tgs.Add("UsersToNotify", UsersToNotify);
            
            return tgs;
        }

        public override void LoadFromTGSerializedObject(TGSerializedObject _tgs)
        {
            base.LoadFromTGSerializedObject(_tgs);

            Name = _tgs.GetString("Name");
            Description = _tgs.GetString("Description");
            CheckEvery = _tgs.GetInt32("CheckEvery");
            NextCheckTime = _tgs.GetDateTime("NextCheckTime");
            UsersToNotify = _tgs.GetListOfGuids("UsersToNotify");
        }
    }
}
