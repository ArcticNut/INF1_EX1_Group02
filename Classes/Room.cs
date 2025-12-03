using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF1_EX1_Group02.Classes
{
    public class Room
    {
        //Attributes
        // Thread-safe id generation
        private static int nextId = 0;

        private readonly int id;
        private string roomNr;
        private double area;
        private Use use;
        private List<Furniture> furnitures;
        private double slabThickness;
        private double slabVol;
        private double cost;
        private double load;

        //Constructor
        public Room(string roomNr, double area,  Use use, double slabThickness)
        {
            this.id = Interlocked.Increment(ref nextId);
            this.roomNr = roomNr;
            this.area = area;
            this.use = use;
            this.furnitures = new List<Furniture>();
            this.slabThickness = slabThickness;
            this.slabVol = CalcSlabVol();
            this.cost = CalcRoomCost();
            this.load = CalcLoad();
        }

        //Getters and Setters
        public int Id { get { return id; } }
        public string RoomNr { get { return roomNr; } set { roomNr = value; } }
        public double Area { get { return area; } set { area = value; } }
        public Use Use { get { return use; } set { use = value; } }
        public List<Furniture> Furnitures { get { return furnitures; } }
        public double SlabThickness { get { return slabThickness; } set { slabThickness = value; } }
        public double SlabVol { get { return slabVol; } }
        public double Cost { get { return cost; } }
        public double Load { get { return load; } }

        //Methods
        public double CalcSlabVol()
        {
            return area * slabThickness;
        }
        public double CalcRoomCost()
        {
            double costPerCubicMeter = 150; //assumed cost per cubic meter of concrete need to research a refernce
            return slabVol * costPerCubicMeter;
        }
        public double CalcLoad()
        {
            double gk = 8; // kN/m²
            return 1.35 * gk + 1.5 * use.Qk;
        }
    }
}
