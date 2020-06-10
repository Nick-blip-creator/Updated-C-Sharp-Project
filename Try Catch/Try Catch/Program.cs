using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                List<int> myValues = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
                Console.WriteLine("Pick a number ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                foreach (int value in myValues)
                {
                    int divided = inputNumber / value;
                    Console.WriteLine(divided);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero. ");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number not a string value ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
            Console.ReadLine();






        }
    }
}



