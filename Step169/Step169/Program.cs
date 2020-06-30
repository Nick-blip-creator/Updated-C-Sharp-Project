using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step169
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1Object = new Class1();
            Console.WriteLine("Choose a number");
            int input = Convert.ToInt32(Console.ReadLine());
            class1Object.intOutput(input);
            Console.Read();
        }
    }
}
