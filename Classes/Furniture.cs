namespace INF1_EX1_Group02.Classes
{
    public class Furniture
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
        public int Amount
        {
            get { return amount; }
        }

        //Methods
        public override string ToString()
        {
            return type + ": " + amount;
        }
    }
}
