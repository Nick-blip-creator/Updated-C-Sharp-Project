using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step164
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1Object = new Class1();
            Console.WriteLine(class1Object.addition(20));
            Console.WriteLine(class1Object.addition(20.82));
            Console.WriteLine(class1Object.addition(31.72 + "Hi"));


            Console.Read();
        }
    }
}
