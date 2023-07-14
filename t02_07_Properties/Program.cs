namespace t02_07_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1972, 9, 16));

            Console.WriteLine(person.Age);
        }
    }
}