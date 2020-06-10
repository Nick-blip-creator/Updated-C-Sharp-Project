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
                List<int> myValues = new List<int>(new int[] { 50, 60, 70, 40, 90, 30, 70, 80, 90, 100 });
                Console.WriteLine("Pick a number ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                foreach (int value in myValues)
                {
                    int divided = value / inputNumber;
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



