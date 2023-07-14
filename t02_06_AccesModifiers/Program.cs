namespace t02_06_AccesModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.SetBirthdate(new DateTime(1972, 9, 16));

            Console.WriteLine(person.GetBirthdate());
        }
    }
}