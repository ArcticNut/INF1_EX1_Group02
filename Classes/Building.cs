namespace INF1_EX1_Group02.Classes
{
    public class Building
    {
        // -------------------------
        // Define Attributes
        // -------------------------
        private string name;
        private double area;
        private double costPerCubicMeter;
        private int totFurniture;
        private double totCost;
        private double height;

        // Relationship: Building has many Floors
        private List<Floor> floors;


        // -------------------------
        // Constructors
        // -------------------------
        public Building(string name, double area, double costPerCubicMeter)
        {
            this.name = name;
            this.area = area;
            this.costPerCubicMeter = costPerCubicMeter;
            totFurniture = 0;
            totCost = 0.0;
            height = 0.0;

            floors = new List<Floor>();
            this.costPerCubicMeter = costPerCubicMeter;
        }


        // -------------------------
        // Getter & Setter
        // -------------------------
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public double CostPerCubicMeter
        {
            get { return costPerCubicMeter; }
        }

        public int TotFurniture
        {
            get { return totFurniture; }
        }

        public double TotCost
        {
            get { return totCost; }
        }

        public double Height
        {
            get { return height; }
        }

        public List<Floor> Floors
        {
            get { return floors; }
        }

        // -------------------------
        // Methods 
        // -------------------------
        public void ClacTotalFurniture()
        {
            int sum = 0;

            foreach (Floor floor in floors)
            {
                sum += floor.CalcTotFurniture();
            }

            totFurniture = sum;
        }

        public void ClacTotalCost()
        {
            double sum = 0.0;

            foreach (Floor floor in floors)
            {
                sum += floor.CalcTotalCost();
            }

            totCost = sum;
        }

        public void ClacTotalHeight()
        {
            double sum = 0.0;
            foreach (Floor floor in floors)
            {
                sum += floor.Height;
            }

            height = sum;
        }

        public double ClacTotalSlabVolume()
        {
            double totVol = 0.0;
            foreach (Floor floor in floors)
            {
                totVol += floor.ClacTotalSlabVolume();
            }
            return totVol;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
