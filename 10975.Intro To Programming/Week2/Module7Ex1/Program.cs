using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello lets calcuate some areas! ");
            ChooseShape();
            Console.WriteLine("You may close the application.");
            Console.ReadLine();
        }

        static void ChooseShape()
        {
            Console.Write("Please select one: 1.Circle 2.Square: ");
            int userResponse = Convert.ToInt32(Console.ReadLine());
            if (userResponse == 1)
            {
                CircleCalculations();
            }
            if (userResponse == 2)
            {
                SquareCalculations();
            }
        }

        static void CircleCalculations()
        {
            Console.WriteLine("Please enter a radius for your circle: ");
            decimal radius = Convert.ToDecimal(Console.ReadLine());
            Circle newCircle = new Circle();
            newCircle.radius = radius;
            Console.WriteLine($"The area of your circle is {newCircle.CalculateArea()}");
            Console.Write("Calculate again? 1.Yes 2.No: ");
            int response = Convert.ToInt32(Console.ReadLine());
            if(response == 1)
            {
                ChooseShape();
            }
           
        }

        static void SquareCalculations()
        {
            Console.WriteLine("Please enter a side for your square: ");
            decimal side = Convert.ToDecimal(Console.ReadLine());
            Square newSquare = new Square();
            newSquare.side = side;
            Console.WriteLine($"The area of your square is {newSquare.CalculateArea()}");
            Console.Write("Calculate again? 1.Yes 2.No: ");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
            {
                ChooseShape();
            }

        }
    }
}
