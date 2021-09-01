using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module3Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList todos = new ArrayList()
            {
                //object initailizers
                new Todo {Description ="Assignment 1", EstiamtedHours= 2, Status = Status.NotStarted},
                new Todo {Description ="Assignment 2", EstiamtedHours= 5, Status = Status.Inprogress},
                new Todo {Description ="Read Chapters 1-4", EstiamtedHours= 5, Status = Status.Inprogress},
                new Todo {Description ="Forum Posts", EstiamtedHours= 2, Status = Status.Completed},
                new Todo {Description ="Chapter Review", EstiamtedHours= 3, Status = Status.NotStarted},
                new Todo {Description ="Call Professor", EstiamtedHours= 1, Status = Status.OnHold},
                new Todo {Description ="Last Week Review", EstiamtedHours= 6, Status = Status.Deleted},
            };

            PrintTodos(todos);
            Console.ReadLine();

        }

        static void PrintTodos(ArrayList todos)
        {
            foreach(var todo in todos)
            {
                Todo task = (Todo)todo;

                switch (task.Status)
                {
                    case (Status)1:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                    case (Status)2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case (Status)3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case (Status)4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case (Status)5:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;


                }
                Console.WriteLine($"Description: {task.Description} | Estimated Hours: {task.EstiamtedHours} | Status: {task.Status}");
            }
        }
    }
}
