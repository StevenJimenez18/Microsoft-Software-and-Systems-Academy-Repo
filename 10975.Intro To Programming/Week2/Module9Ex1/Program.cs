using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Documents;
using System.Collections;
using System.Threading;

namespace Module9Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the file manager.");
            Menu();
            Console.WriteLine("You may close the application now.");
            Console.ReadLine();
        }
        static void Menu()
        {
            Console.WriteLine("Lets get your information: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            string age = Console.ReadLine();
            Console.Write("Home State: ");
            string homeState = Console.ReadLine();

            CreateFile(ref name, ref age, ref homeState);

        }

        static void CreateFile(ref string name, ref string age, ref string homeState)
        {

            string path = @"C:\Files\";
            Console.WriteLine("Please enter a file name: ");
            string fileName = Console.ReadLine() + ".txt";
            Console.WriteLine("Creating file...");
            for (var i = 0; i <= 100; ++i)
            {
                ConsoleUtility.WriteProgressBar(i, true);
                Thread.Sleep(20);
            }
            path = path + fileName;
            if (!File.Exists(path))
            {
                StreamWriter sw = null;
                try
                {
                    sw = File.CreateText(path);
                    Console.WriteLine($" Your file {fileName} was created successfully...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sw.Close();
                }
            }
            else
            {
                Console.WriteLine("File already exists");
            }

            Console.WriteLine("Inputting your data into your file...");
            for (var i = 0; i <= 100; ++i)
            {
                ConsoleUtility.WriteProgressBar(i, true);
                Thread.Sleep(20);
            }
            Console.WriteLine(" Data has been inserting successfully...");
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name:{name} \n Age:{age} \n Home State:{homeState}");
            StreamWriter appendWriter = null;
            try
            {

                appendWriter = File.AppendText(path);
                appendWriter.WriteLine(sb);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                appendWriter.Close();

            }

            Console.WriteLine("Lets read your file now...");
            Console.WriteLine();
            Console.WriteLine("Start of File: ");
            Console.WriteLine();
            using (StreamReader reader = File.OpenText(path))
            {
                string s;
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine();
            Console.WriteLine("End of File: ");
        }

        public class ConsoleUtility
        {
            const char _block = '■';
            const string _back = "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b";
            const string _twirl = "-\\|/";
            public static void WriteProgressBar(int percent, bool update = false)
            {
                if (update)
                    Console.Write(_back);
                Console.Write("[");
                var p = (int)((percent / 10f) + .5f);
                for (var i = 0; i < 10; ++i)
                {
                    if (i >= p)
                        Console.Write(' ');
                    else
                        Console.Write(_block);
                }
                Console.Write("] {0,3:##0}%", percent);
            }
            public static void WriteProgress(int progress, bool update = false)
            {
                if (update)
                    Console.Write("\b");
                Console.Write(_twirl[progress % _twirl.Length]);
            }
        }
    }

}
