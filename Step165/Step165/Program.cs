using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step165
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1Object = new Class1();
            Console.WriteLine(class1Object.addition(5));

            Console.WriteLine("Please input two numbers");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The second number is optional");
            string inputTwo = Console.ReadLine();

            if (string.IsNullOrEmpty(inputTwo))
            {
                Console.WriteLine(class1Object.addition(inputOne));

            }
            else
            {
                int inputTwoNumber = Int32.Parse(inputTwo);
                Console.WriteLine(class1Object.addition(inputOne, inputTwoNumber));

            }





            Console.Read();


        }
    }
}
