﻿namespace t04_02_Constructors
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine($"Car is being inialized. Registration number: {registrationNumber}");
        }
    }
}