using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORRECTEdStep164
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1Object = new Class1();
            Console.Write(class1Object.addition(20));
            Console.Write(class1Object.addition(20.82m));
            Console.Write(class1Object.addition("10"));

            Console.Read();
        }
    }
}
