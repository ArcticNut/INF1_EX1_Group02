using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF1_EX1_Group02.Classes
{
    internal class Use
    {
        // Attributes
        private static int id = 0;
        private string name;
        private double qk; //live load in kN/m²

        public Use(string name, double qk)
        {
            id = id++;
            this.name = name;
            this.qk = qk;
        }

        // Getters and Setters
        public int Id { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public double Qk { get { return qk; } set { qk = value; } }

        // Methods
        public override string ToString()
        {
            return name;
        }

    }
}
