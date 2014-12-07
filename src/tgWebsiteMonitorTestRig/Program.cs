using TreeGecko.Library.Common.Helpers;
using TreeGecko.WebMonitor.Library.Manager;

namespace TreeGecko.WebMonitor.TestRig
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TraceFileHelper.SetupLogging();

            if (args != null
                && args.Length > 0)
            {
                string method = args[0].ToLower();

                switch (method)
                {
                    case "builddb":
                        BuildDB();
                        break;
                    case "":
                        break;
                    case "monitor":
                        Monitor();
                        break;
                }

            }

            TraceFileHelper.TearDownLogging();
        }

        private static void Monitor()
        {
            WebsiteMonitorManager manager = new WebsiteMonitorManager();
            

        }

        private static void BuildDB()
        {
            WebsiteMonitorStructureManager wmsm = new WebsiteMonitorStructureManager();
            wmsm.BuildDB();
        }

    }
}
