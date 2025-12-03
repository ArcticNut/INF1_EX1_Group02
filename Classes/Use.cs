using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF1_EX1_Group02.Classes
{
    public class Use
    {
        // Attributes
        
        // Thread-safe id generation
        private static int nextId = 0;

        private readonly int id;
        private string name;
        private double qk; //live load in kN/m²

        public Use(string name, double qk)
        {
            this.id = Interlocked.Increment(ref nextId);
            this.name = name;
            this.qk = qk;
        }

        // Getters and Setters
        public int Id { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public double Qk { get { return qk; } set { qk = value; } }

        public override string ToString()
        {
            return name;
        }
    }
}
