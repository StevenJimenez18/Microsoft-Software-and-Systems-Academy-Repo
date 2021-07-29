using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Console.WriteLine("You may close the application");
            Console.ReadLine();
        }

        static void Intro()
        {
            Console.Write("Enter a word to be reversed: ");
            string word = Console.ReadLine();
            ReverseString(word);
        }
        static void ReverseString(string word)
        {
            StringBuilder reversedWord = new StringBuilder();

            for(int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord.Append(word[i]);
            }

            Console.WriteLine($"{word} reversed is {reversedWord}.");

            TryAgain();
        }

        static void TryAgain()
        {
            Console.WriteLine("Would you like to enter another word? Y/N");
            char answer = Convert.ToChar(Console.ReadLine());
            if (answer == 'y' || answer == 'Y')
            {
                Intro();
            }
            if (answer == 'N' || answer == 'n')
            {
                return;
            }
            else if (answer == 'Y' || answer == 'y' || answer == 'N' || answer == 'n')
            {
                Console.WriteLine("You did not make a valid selection");
                TryAgain();
            }
        }
    }
}
