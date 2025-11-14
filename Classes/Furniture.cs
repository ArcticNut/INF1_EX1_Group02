using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF1_EX1_Group02.Classes
{
    internal class Furniture
    {
        // Define Attributes
        private string type;
        private int amount;

        // Constructors
        public Furniture(string type, int amount)
        {
            this.type = type;
            this.amount = amount;
        }
        
        // Getter and Setter
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        //Methods
        public override string ToString()
        {
            return type + ": " + amount;
        }
    }
}
