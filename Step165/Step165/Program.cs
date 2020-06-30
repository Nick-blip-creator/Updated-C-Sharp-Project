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
            int inputTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(class1Object.addition(inputOne, inputTwo));



            Console.Read();


        }
    }
}
