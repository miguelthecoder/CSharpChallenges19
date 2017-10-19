using System;

namespace ChallengeFourTL
{
    class Program
    {
        static void Main(string[] args)
        {
            var DreamCar = new Car(4, "Luxury Car", 2017, "Rolls-Royce Phantom");
            var UglyCar = new Car(4, "", 2015, "Smart Car");
            Console.WriteLine("The Car of all my dreams is " + " " + DreamCar.Year + " " + DreamCar.Model);
            Console.WriteLine("I mean look at me, 5 foot one this car is soo small and ugly.." + " " + UglyCar.Year + " " + UglyCar.Model);
        }
    }
    public class Car
    {
        public int Tires { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }

        public Car(int tires, string type, int year, string model) 
        {
            Tires = tires;
            Type = type;
            Year = year;
            Model = model;
        }
    }
}
