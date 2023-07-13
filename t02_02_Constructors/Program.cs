namespace t02_02_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Jugoslav");

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}