using TreeGecko.Library.Common.Objects;

namespace TreeGecko.WebMonitor.Library.Objects
{
    public class WebSite : AbstractTGObject    
    {
        public string Url { get; set; }
        public int CheckEvery { get; set; }

        public override TGSerializedObject GetTGSerializedObject()
        {
            TGSerializedObject tgs = base.GetTGSerializedObject();

            tgs.Add("Url", Url);
            tgs.Add("CheckEvery", CheckEvery);

            return tgs;
        }

        public override void LoadFromTGSerializedObject(TGSerializedObject _tgs)
        {
            base.LoadFromTGSerializedObject(_tgs);

            Url = _tgs.GetString("Url");
            CheckEvery = _tgs.GetInt32("CheckEvery");
        }
    }
}
