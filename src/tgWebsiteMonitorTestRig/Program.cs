using TreeGecko.Library.Common.Helpers;

namespace TreeGecko.WebMonitor.TestRig
{
    class Program
    {
        static void Main(string[] args)
        {
            TraceFileHelper.SetupLogging();

            if (args != null
                && args.Length > 0)
            {
                string method = args[0].ToLower();

                switch (method)
                {
                    case "builddb":
                        break;
                    case "":
                        break;
                    case "monitor":
                        break;
                }

            }

            TraceFileHelper.TearDownLogging();
        }
    }
}
