using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Demo1
{
    class Program
    {
        static string name;
        static string address;
        static string state;
        static int zipCode;
        static int phoneNumber;
        static int tempAnimal;
        static string favAnimal;
        static string answer;
        static string temp;
        static bool result;
        
        static void Main(string[] args)
        {
            /*GetName();
            GetAddress();
            GetState();
            GetZipCode();
            GetPhoneNumber();
            PrintFinalStatement();*/
            //GetFavoriteAnimal();
            GetNum();

            Console.ReadLine();

            char myChar = 'A';
            char.ToUpper(myChar);
        }

        static void GetName()
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Thank you {name}.");
        }

        static void GetAddress()
        {

            Console.Write("Please enter your street address: ");
            address = Console.ReadLine();
            address = ValidateStringAnswer(address);
        }

        static void GetState()
        {
            Console.Write("Please enter your state: ");
            state = Console.ReadLine();
            state = ValidateStringAnswer(state);
        }

        static void GetZipCode()
        {
            Console.Write("Please enter your zip code: ");
            temp = Console.ReadLine();
            result = int.TryParse(temp, out zipCode);
            zipCode = ValidateIntAnswer(zipCode);
        }

        static void GetPhoneNumber()
        {
            Console.Write("Please enter your phone number: ");
            temp = Console.ReadLine();
            result = int.TryParse(temp, out phoneNumber);
            phoneNumber = ValidateIntAnswer(phoneNumber);
        }

        static void PrintFinalStatement()
        {
            Console.WriteLine($"Thank you {name}. Your address is {address}, {state} {zipCode}. Phone number: {phoneNumber}");
        }

        static string ValidateStringAnswer(string entry)
        {
            Console.Write($"Is {entry} correct? yes/no: ");
            answer = Console.ReadLine();
            answer.ToLower();
            if (answer == "no")
            {
                Console.Write($"Please renter {entry}: ");
                entry = Console.ReadLine();
            }
            return entry;
        }

        static int ValidateIntAnswer(int entry)
        {
            Console.Write($"Is {entry} correct? yes/no: ");
            answer = Console.ReadLine();
            answer.ToLower();
            if (answer == "no")
            {
                Console.Write($"Please renter {entry}: ");
                temp = Console.ReadLine();
                result = int.TryParse(temp, out entry);
            }
            return entry;
        }
        static void GetFavoriteAnimal()
        {
            Console.WriteLine("What is your Favorite Animal? 1.Tiger 2.Cheetah 3.Bear 4.Dog");
            tempAnimal = Convert.ToInt32(Console.ReadLine());
            switch (tempAnimal)
            {
                case 1:
                    favAnimal = "Tiger";
                    Console.WriteLine($"Your favorite animal is a {favAnimal}");
                    break;
                case 2:
                    favAnimal = "Cheetah";
                    Console.WriteLine($"Your favorite animal is a {favAnimal}");
                    break;
                case 3:
                    favAnimal = "Bear";
                    Console.WriteLine($"Your favorite animal is a {favAnimal}");
                    break;
                case 4:
                    favAnimal = "Dog";
                    Console.WriteLine($"Your favorite animal is a {favAnimal}");
                    break;
                default:
                    Console.WriteLine("Didnt select a valid choice");
                    GetFavoriteAnimal();
                    break;
            }
        }

        static void GetNum()
        {
            Console.WriteLine("Please enter two numbers: ");
            Console.Write($"Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            SelectOperation(num1, num2);
            
        }

        static void SelectOperation(int num1, int num2)
        {
            Console.Write("Please select which operation you would like: 1.Add 2.Subtract 3.Divide: ");
            int result = Convert.ToInt32(Console.ReadLine());
            switch (result)
            {
                case 1:
                    result = Add(num1, num2);
                    Console.WriteLine($"Result is: {result}");
                    break;
                case 2:
                    result = Sub(num1, num2);
                    Console.WriteLine($"Result is: {result}");
                    break;
                case 3:
                    result = Div(num1, num2);
                    Console.WriteLine($"Result is: {result}");
                    break;
                default:
                    Console.WriteLine("Didnt select a valid choice");
                    SelectOperation(num1, num2);
                    break;
            }
        }
        static int Add(int i, int j)
        {
            return i + j;
        }

        static int Sub(int i, int j)
        {
            return i - j;
        }

        static int Div(int i, int j)
        {
            return i / j;
        }
    }
}
