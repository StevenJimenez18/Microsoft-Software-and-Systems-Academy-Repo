using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        class Car
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public double Price { get; set; }
        }
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car1.VIN = "1k2k4s3d0";
            Car1.Make = "Lexus";
            Car1.Model = "Is250";
            Car1.Year = 2020;
            Car1.Price = 25000;
            
            Car Car2 = new Car();
            Car2.VIN = "2a5f7h9c4e9s";
            Car2.Make = "BMW";
            Car2.Model = "550I";
            Car2.Year = 2019;
            Car2.Price = 18500;
            
            Car Car3 = new Car();
            Car3.VIN = "2a5f7h9c4e9s";
            Car3.Make = "Honda";
            Car3.Model = "Civic";
            Car3.Year = 2021;
            Car3.Price = 22000;

            Car Car4 = new Car();
            Car4.VIN = "2a5f7h9c4e9s";
            Car4.Make = "BMW";
            Car4.Model = "550I";
            Car4.Year = 2005;
            Car4.Price = 20000;
            
            Car Car5 = new Car();
            Car5.VIN = "2a5f7h9c4e9s";
            Car5.Make = "BMW";
            Car5.Model = "550I";
            Car5.Year = 2005;
            Car5.Price = 27000;


            List<Car> myCars = new List<Car>() { Car1, Car2, Car3, Car4, Car5};

            //Deffered Execution
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       select car;

            foreach( var c in bmws)
            {
                Console.WriteLine($"Make: {c.Make}, Model: {c.Model}, Year: {c.Year}, Price: {c.Price}");
            }


            Console.WriteLine("--------------");
            //Forced execution
            var bmwList = (from car in myCars
                       where car.Make == "BMW"
                       select car).ToList();

            var orderedCars = from car in myCars
                              orderby car.Price descending
                              select car;

            foreach (var c in orderedCars)
            {
                Console.WriteLine($"Make: {c.Make}, Model: {c.Model}, Year: {c.Year}, Price: {c.Price}");
            }


            Console.WriteLine("---------------");

            //Lambda Exprresion Query

            var listbmws = myCars.Where(c => c.Make == "BMW" && c.Price < 25000);

            foreach(var c in listbmws)
            {
                Console.WriteLine($"Make: {c.Make}, Model: {c.Model}, Year: {c.Year}, Price: {c.Price}");
            }

            Console.WriteLine("---------------");

            //Lambda foreach
            myCars.ForEach(c => Console.WriteLine($"Make: {c.Make}, Price: {c.Price}"));

            Console.WriteLine("---------------");

            //aggregate functions

            Console.WriteLine("Sum of prices: {0:c}", myCars.Sum(c => c.Price));
            
            Console.WriteLine("max of prices: {0:c}", myCars.Max(c => c.Price));

            Console.ReadLine();
        }
    }
}
