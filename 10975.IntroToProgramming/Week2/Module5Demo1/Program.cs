using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5Demo1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num1, num2, result;
            num1 = 100;
            num2 = 0;
            try
            {
                result = num1 / num2;
                
            }
            catch (DivideByZeroException ex) //specific catch
            {
                //logging 
                Console.WriteLine(ex.Message);
                
            }
            catch (Exception ex) // Exception is base class - (general)
            {

            }
            finally
            {
                //madatory code block ( closing connections/ finalizations)
                //Returns can not happen from finally
                Console.WriteLine("Error was found.");
            }
            Console.ReadLine();
        }

        static void Add()
        {

        }
    }
}
