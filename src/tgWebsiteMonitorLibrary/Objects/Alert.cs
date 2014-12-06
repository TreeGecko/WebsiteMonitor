using System;
using System.Collections.Generic;
using TreeGecko.Library.Common.Objects;

namespace TreeGecko.WebMonitor.Library.Objects
{
    public class Alert : AbstractTGObject
    {
        public bool IsCurrent { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public List<Guid> WebSiteGuids { get; set; }
        public List<Guid> NotifiedUsers { get; set; }
        public string AlertType { get; set; }

        public override TGSerializedObject GetTGSerializedObject()
        {
            TGSerializedObject tgs = base.GetTGSerializedObject();

            tgs.Add("IsCurrent", IsCurrent);
            tgs.Add("StartDateTime", StartDateTime);
            tgs.Add("EndDateTime", EndDateTime);
            tgs.Add("WebSiteGuids", WebSiteGuids);
            tgs.Add("NotifiedUsers", NotifiedUsers);
            tgs.Add("AlertType", AlertType);

            return tgs;
        }

        public override void LoadFromTGSerializedObject(TGSerializedObject _tgs)
        {
            base.LoadFromTGSerializedObject(_tgs);

            IsCurrent = _tgs.GetBoolean("IsCurrent");
            StartDateTime = _tgs.GetDateTime("StartDateTime");
            EndDateTime = _tgs.GetNullableDateTime("EndDateTime");
            WebSiteGuids = _tgs.GetListOfGuids("WebSiteGuids");
            NotifiedUsers = _tgs.GetListOfGuids("NotifiedUsers");
            AlertType = _tgs.GetString("AlertType");
        }
    }
}
