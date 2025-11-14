using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF1_EX1_Group02.Classes
{
    // This class is added to save a preset of data for the appliation
    // Here it serves to have an intial list of Room Uses for the User to choose from
    public static class AppData
    {
        private static List<Use> uses;

        public static List<Use> Uses
        {
            get { return uses; }
        }

        static AppData()
        {
            uses = new List<Use>();
            // qK value based on Eurocode DIN EN 1991-1-1/NA, Tab 6.1 DE.
            uses.Add(new Use("office", 3.0));
            uses.Add(new Use("apartments", 2.0));
            uses.Add(new Use("restaurants", 3.0));
            uses.Add(new Use("fitness center", 5.0));
        }


    }
}
