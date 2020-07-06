using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingStep234
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("What year were you born?");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You were born in: " + userInput);
                Console.Read();

                if (userInput <= 0)
                {
                    Console.WriteLine("Please enter a valid number that isn't zero or a negative number.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong...");
            }
            Console.Read();

            }
    }
    }


