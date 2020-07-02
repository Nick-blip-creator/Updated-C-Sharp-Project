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


            employed1.ID = 2342;
            employed2.ID = 3234;
            employed.getID();
            Console.Read();
        }
    }
}
