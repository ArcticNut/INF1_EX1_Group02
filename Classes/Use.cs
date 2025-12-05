namespace INF1_EX1_Group02.Classes
{
    public class Use
    {
        // Attributes
        private string name;
        private double qk; //live load in kN/m²

        public Use(string name, double qk)
        {
            this.name = name;
            this.qk = qk;
        }

        // Getters and Setters
        public string Name { get { return name; } set { name = value; } }
        public double Qk { get { return qk; } set { qk = value; } }

        public override string ToString()
        {
            return name;
        }
    }
}
