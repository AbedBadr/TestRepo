using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person test = new Person(Person.Genders.Male, 1, "Jarred", 25);
            Vehicle vehicle = new Vehicle(Vehicle.Type.Hatchback, Vehicle.Make.VW, 3213341, "Golf 4");

        }
    }
}
