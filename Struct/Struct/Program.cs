using Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Structs.Class1;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Numbers = 748.5m;
            Console.WriteLine(number.Numbers);
            Console.Read();
        }
    }
}
