namespace t02_05_Fields
{
    internal class Customer
    {
        internal int Id;
        internal string Name;
        internal readonly List<Order> Orders = new();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        internal void Promote()
        {
            // ....
        }
    }
}