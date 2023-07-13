namespace t02_02_Constructors
{
    internal class Customer
    {
        internal int Id;
        internal string Name;

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}