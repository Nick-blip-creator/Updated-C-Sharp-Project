using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step187pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employed1 = new Employee();
            Employee employed2 = new Employee();
            Employee employed = new Employee();


            Console.WriteLine(employed1 == employed2);
            Console.WriteLine(employed1 != employed2);
            Console.Read();

        }
        
    }
}
