using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Documents;
using System.Collections;

namespace Module9Demo1
{
    class Program
    {
        static Dictionary<int, string> fileList = new Dictionary<int, string>();
        static int dictCounter = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the file manager.");
            Console.WriteLine("What would you like to do today?");
            Menu();
            Console.WriteLine("You may close the application now.");
            Console.ReadLine();
        }
        static void Menu()
        {
            Console.Write("Menu options - 1.Create 2.Update 3.Read 4.Copy 5.Delete 6.Quit: ");
            int userResponse; 
            string tempStr = Console.ReadLine();
            bool result = int.TryParse(tempStr, out userResponse);
           
            switch (userResponse)
            {
                case 1:
                    Console.Clear();
                    CreateFile();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    UpdateFile();
                    Menu();
                    break;
                case 3:
                    Console.Clear();
                    ReadFile();
                    Menu();
                    break;
                case 4:
                    Console.Clear();
                    CopyFile();
                    Menu();
                    break;
                case 5:
                    Console.Clear();
                    DeleteFile();
                    break;
                case 6:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("A valid choice was not selected. Please try again.");
                    Menu();
                    break;
            }

        }

        static void CreateFile()
        {

            string path = @"C:\Files\";
            Console.WriteLine("Please enter a file name");
            string fileName = Console.ReadLine() + ".txt";
            path = path + fileName;
            Console.WriteLine("Creating file...");
            if (!File.Exists(path))
            {
                StreamWriter sw = null;
                try
                {
                    sw = File.CreateText(path);
                    Console.WriteLine($"Your {fileName} was created");
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
            
            dictCounter++;
            fileList.Add(dictCounter,path);
            
        }

        static void UpdateFile()
        {
            
            Console.WriteLine("Please select a file you would like to update: ");
            foreach(var item in fileList)
            {
                
                string substring = item.Value.Substring(9);
                Console.WriteLine($"{item.Key}.{substring}");
            }
            Console.Write("Selection number: ");
            int userResponse;
            string tempStr = Console.ReadLine();
            bool result = int.TryParse(tempStr, out userResponse);
            string path = fileList[userResponse];
            Console.WriteLine("Please enter the information you would like to add to your file: ");
            string newData = Console.ReadLine();
            StreamWriter appendWriter = null;
            try
            {

                appendWriter = File.AppendText(path);
                appendWriter.WriteLine(newData);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                appendWriter.Close();

            }
            
        }

        static void ReadFile()
        {
            Console.WriteLine("Please select a file you would like to read: ");
            foreach (var item in fileList)
            {

                string substring = item.Value.Substring(9);
                Console.WriteLine($"{item.Key}.{substring}");
            }
            Console.Write("Selection number: ");
            int userResponse;
            string tempStr = Console.ReadLine();
            bool result = int.TryParse(tempStr, out userResponse);
            string path = fileList[userResponse];
            Console.WriteLine();
            Console.WriteLine("File Start: ");
            using (StreamReader reader = File.OpenText(path))
            {
                string s;
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine(":File End");
            Console.WriteLine();
        }

        static void CopyFile()
        {
            Console.WriteLine("Please select a file you would like to copy: ");
            foreach (var item in fileList)
            {

                string substring = item.Value.Substring(9);
                Console.WriteLine($"{item.Key}.{substring}");
            }
            Console.Write("Selection number: ");
            int userResponse;
            string tempStr = Console.ReadLine();
            bool result = int.TryParse(tempStr, out userResponse);
            string path = fileList[userResponse];
            Console.Write("Please enter the name of the new file: ");
            string newFile = @"C:\Files\" + Console.ReadLine() + ".txt";
            File.Copy(path, newFile);
            dictCounter++;
            fileList.Add(dictCounter, newFile);

        }

        static void DeleteFile()
        {
            Console.WriteLine("Please select a file you would like to delete: ");
            string substring;
            foreach (var item in fileList)
            {
                substring = item.Value.Substring(9);
                Console.WriteLine($"{item.Key}.{substring}");
            }
            Console.Write("Selection number: ");
            int userResponse;
            string tempStr = Console.ReadLine();
            bool result = int.TryParse(tempStr, out userResponse);
            string path = fileList[userResponse];
            substring = path.Substring(9);
            path = fileList[userResponse];
            Console.WriteLine($"Are you sure you would like to delete {substring}? 1.Yes 2.No: ");
            tempStr = Console.ReadLine();
            result = int.TryParse(tempStr, out userResponse);
            if (userResponse == 1)
            {
                try
                {
                    File.Delete(path);
                    Console.WriteLine("Your file was deleted permanently");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine($"{substring} was not deleted.");
            }
            
        }
    }

}
