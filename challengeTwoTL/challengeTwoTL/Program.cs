using System;

namespace challengeTwoTL
{
    class Program
    {
        class Car
        {
            public int numberOfTires { get; set; } 
            public int year { get; set; }    
            public string model { get; set; }    

        }
        class mainClass 
        {
            static void Main()
            {
                var carOne = new Car
                {
                    numberOfTires = 4,
                    year = 2013,
                    model = "Honda Accord"
                };
                Console.WriteLine($"The first car is a Year: {carOne.year} Model: {carOne.model}");
                var carTwo = new Car
                {
                    numberOfTires = 4,
                    year = 2003,
                    model = "Dodge Stratus"
                };
                Console.WriteLine($"The second car is a Year: {carTwo.year} Model: {carTwo.model}");
                var carThree = new Car
                {
                    numberOfTires = 4,
                    year = 2009,
                    model = "Toyota Camry"
                };
                Console.WriteLine($"The third car is a Year: {carThree.year} Model: {carThree.model}");
            }
        }
    }
}
