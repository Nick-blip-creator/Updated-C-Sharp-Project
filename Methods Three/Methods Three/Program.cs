using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Three
{
    class Program
    {
        static void Main(string[] args)
        {

            division divisionObject = new division();
            Console.WriteLine(divisionObject.addition(5));
            Console.WriteLine(divisionObject.subtraction(50));
            Console.WriteLine(divisionObject.multipication(50));
            Console.Read();


        }
    }
}
