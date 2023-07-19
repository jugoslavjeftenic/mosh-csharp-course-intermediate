namespace t04_02_Constructors
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initilized.");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine($"Vehicle is being initilized. Registration number: {registrationNumber}");
        }
    }
}