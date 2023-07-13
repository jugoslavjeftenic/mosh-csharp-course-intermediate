namespace t02_01_Classes
{
    internal class Person
    {
        internal string? Name;

        internal void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}.", to, Name);
        }

        internal static Person Parse(string str)
        {
            Person person = new();
            person.Name = str;

            return person;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person jugoslav = new();
            jugoslav.Name = "Jugoslav";

            var mosh = new Person();
            mosh.Name = "Mosh";

            jugoslav.Introduce(mosh.Name);

            var perica = Person.Parse("Perica");
            jugoslav.Introduce(perica.Name);
        }
    }
}