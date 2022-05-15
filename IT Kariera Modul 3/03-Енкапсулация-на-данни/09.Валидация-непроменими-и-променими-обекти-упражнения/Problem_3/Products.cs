namespace ConsoleApp297
{
    internal class Products
    {
        private string name;
        private double cost;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }



        public Products(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}