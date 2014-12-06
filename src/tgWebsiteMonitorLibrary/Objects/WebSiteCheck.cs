using System;
using TreeGecko.Library.Common.Objects;

namespace TreeGecko.WebMonitor.Library.Objects
{
    public class WebSiteCheck : AbstractTGObject
    {
        /// <summary>
        /// 
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CheckDateTime { get; set; }

        /// <summary>
        /// Time in seconds that the response was returned.
        /// </summary>
        public double ResponseTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override TGSerializedObject GetTGSerializedObject()
        {
            TGSerializedObject tgs = base.GetTGSerializedObject();

            tgs.Add("Result", Result);
            tgs.Add("CheckDateTime", CheckDateTime);
            tgs.Add("ResponseTime", ResponseTime);
            tgs.Add("StatusCode", StatusCode);
            tgs.Add("ErrorMessage", ErrorMessage);

            return tgs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_tgs"></param>
        public override void LoadFromTGSerializedObject(TGSerializedObject _tgs)
        {
            base.LoadFromTGSerializedObject(_tgs);

            Result = _tgs.GetString("Result");
            CheckDateTime = _tgs.GetDateTime("CheckDateTime");
            ResponseTime = _tgs.GetInt32("ResponseTime");
            StatusCode = _tgs.GetString("StatusCode");
            ErrorMessage = _tgs.GetString("ErrorMessage");
        }
    }
}
