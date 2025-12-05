using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace INF1_EX1_Group02.Classes
{
    //Nida
    public class Floor
    {
        // ------- Attributes -------
        // Thread-safe id generation
        private static int nextId = 0;

        private readonly int id;
        private int level;                 //  0 = ground floor, 1 = first floor
        private double height;             // storey height in m
        private List<Room> rooms;


        // ------- Constructor -------

        public Floor(int level, double height)
        {
            this.id = Interlocked.Increment(ref nextId);
            this.level = level;
            this.height = height;
            this.rooms = new List<Room>();
        }

        // ------- Getters and Setters (Properties) -------

        public int Id { get { return id; } }

        public int Level { get { return level; } set { level = value; } }

        public double Height { get { return height; } set { height = value; } }

        public List<Room> Rooms { get { return rooms; } }



        // ------- Methods -------

        // total furniture items on this floor 
        public int CalcTotFurniture()
        {

            int total = 0;
            foreach (Room room in rooms)
            {
                List<Furniture> furnitures = room.Furnitures;

                foreach (Furniture furniture in furnitures)
                {
                    total += furniture.Amount;
                }
            }
            return total;
        }

        // total slab volume for this floor
        public double ClacTotalslabVolume()
        {
            double sum = 0.0;
            foreach (Room room in rooms)
            {
                sum += room.SlabVol;
            }
            return sum;
        }

        // total concrete cost of all rooms on this floor
        public double CalcTotalCost()
        {
            double sum = 0.0;
            foreach (Room room in rooms)
            {
                sum += room.Cost;
            }
            return sum;
        }

        // Calculate used space for the floor
        public double CalcSpace()
        {
            double usedArea = 0.0;
            foreach (Room room in rooms)
            {
                usedArea += room.Area;
            }
            return usedArea;
        }

        public override string ToString()
        {
            return level.ToString() + ". Floor";
        }

    }

}
