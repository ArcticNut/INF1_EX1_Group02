using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF1_EX1_Group02.Classes
{
    internal class Building
    {// -------------------------
        // Define Attributes
        // -------------------------
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
        public Building()
        {
            name = "";
            area = 0.0;
            totFurniture = 0;
            totCost = 0.0;
            height = 0.0;

            floors = new List<Floor>();
        }

        public Building(string name, double area)
        {
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
        // Methods for managing Floors
        // -------------------------
        public void AddFloor(Floor floor)
        {
            floors.Add(floor);
        }

        public void RemoveFloor(Floor floor)
        {
            floors.Remove(floor);
        }


        // -------------------------
        // Methods required by UML
        // -------------------------
        public void totalFurniture()
        {
            int sum = 0;

            foreach (Floor floor in floors)
            {
                foreach (Room room in floor.Rooms)
                {
                    foreach (Furniture f in room.Furnitures)
                    {
                        sum += f.Amount;
                    }
                }
            }

            totFurniture = sum;
        }

        public void totalCost()
        {
            double sum = 0.0;

            foreach (Floor floor in floors)
            {
                foreach (Room room in floor.Rooms)
                {
                    sum += room.Cost;
                }
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
     
    }
}
