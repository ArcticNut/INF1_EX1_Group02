
namespace INF1_EX1_Group02.Classes
{
    // This class is added to save a preset of data for the appliation
    // Here it serves to have an intial list of Room Uses for the User to choose from
    public static class AppData
    {
        private static List<Use> uses;
        private static List<Building> buildings;

        public static List<Use> Uses
        {
            get { return uses; }
        }

        public static List<Building> Buildings
        {
            get { return buildings; }
        }

        static AppData()
        {
            uses = new List<Use>();
            buildings = new List<Building>();
            // qK value based on Eurocode DIN EN 1991-1-1/NA, Tab 6.1 DE.
            uses.Add(new Use("Office", 3.0));
            uses.Add(new Use("Apartments", 2.0));
            uses.Add(new Use("Restaurants", 3.0));
            uses.Add(new Use("Fitness Center", 5.0));
        }


    }
}
