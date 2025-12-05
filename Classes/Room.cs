using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace INF1_EX1_Group02.Classes
{
    public class Room
    {
        //Attributes
        private string roomNr;
        private double area;
        private Use use;
        private List<Furniture> furnitures;
        private double slabThickness;
        private double slabVol;
        private double cost;
        private double load;

        //Constructor
        public Room(string roomNr, double area,  Use use, double slabThickness, Building building)
        {
            this.roomNr = roomNr;
            this.area = area;
            this.use = use;
            this.furnitures = new List<Furniture>();
            this.slabThickness = slabThickness;
            CalcSlabVol();
            CalcRoomCost(building);
            CalcLoad();
        }

        //Getters and Setters
        public string RoomNr { get { return roomNr; } set { roomNr = value; } }
        public double Area { get { return area; } set { area = value; } }
        public Use Use { get { return use; } set { use = value; } }
        public List<Furniture> Furnitures { get { return furnitures; } }
        public double SlabThickness { get { return slabThickness; } set { slabThickness = value; } }
        public double SlabVol { get { return slabVol; } }
        public double Cost { get { return cost; } }
        public double Load { get { return load; } }

        //Methods
        public void CalcSlabVol()
        {
            slabVol = area * slabThickness;
        }
        public void CalcRoomCost(Building building)
        {
            if (building == null)
            {
                throw new ArgumentNullException(nameof(building), "Building cannot be null when calculating room cost.");
            }
            double costPerCubicMeter = building.CostPerCubicMeter;
            CalcSlabVol();
            cost = slabVol * costPerCubicMeter;
        }
        public void CalcLoad()
        {
            double gk = 8; // kN/m²
            load = 1.35 * gk + 1.5 * use.Qk;
        }

        public override string ToString()
        {
            return roomNr;
        }
    }
}
