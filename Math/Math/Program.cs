using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two nummbers to multiply");
            double num1 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The total is: " + num1 * num2);
            Console.WriteLine("Enter a number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = 25 + num3;
            Console.WriteLine("The total is : " + num4);
            Console.WriteLine("We will divide now");
            int divide = Convert.ToInt32(Console.ReadLine());
            float numberToDivide = 12.5f;
            float totalDivide = divide / numberToDivide;
            Console.WriteLine(totalDivide);
            Console.WriteLine("We will check if it's greater than 50");
            int comparisonNumber = Convert.ToInt32(Console.ReadLine());
            bool greaterThan = comparisonNumber > 50;
            Console.Write(greaterThan);
            Console.WriteLine("Breakdown number further");
            int userInputNumber = Convert.ToInt32(Console.ReadLine());
            float numDivide = 7 % userInputNumber;
            float totalDivision = numDivide;
            Console.WriteLine(totalDivision);
            Console.ReadLine();



        }
    }
}
