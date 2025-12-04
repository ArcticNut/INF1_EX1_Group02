using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF1_EX1_Group02.Classes
{
    public class Building
    {
        // -------------------------
        // Define Attributes
        // -------------------------
        // Thread-safe id generation
        private static int nextId = 0;

        private readonly int id;

        private string name;
        private double area;
        private int totFurniture;
        private double totCost;
        private double height;

        // Relationship: Building has many Floors
        private List<Floor> floors;


        // -------------------------
        // Constructors
        // -------------------------
        public Building(string name, double area)
        {
            this.id = Interlocked.Increment(ref nextId);
            this.name = name;
            this.area = area;
            totFurniture = 0;
            totCost = 0.0;
            height = 0.0;

            floors = new List<Floor>();
        }


        // -------------------------
        // Getter & Setter
        // -------------------------
        public int Id { get { return id; } }

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
        public void totalFurniture()
        {
            int sum = 0;

            foreach (Floor floor in floors)
            {
                sum += floor.CalcTotFurniture();
            }

            totFurniture = sum;
        }

        public void totalCost()
        {
            double sum = 0.0;

            foreach (Floor floor in floors)
            {
                sum += floor.CalcTotalCost();
            }

            totCost = sum;
        }

        public void totalHeight()
        {
            double sum = 0.0;
            foreach (Floor floor in floors)
            {
                sum += floor.Height;
            }

            height = sum;
        }

        public double totalSlabVolume()
        {
            //sum slab volume for all floor (using the method from floor class)
            double totVol = 0.0;
            return totVol;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
