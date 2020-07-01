using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step174
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employed = new Employee();
            employed.FirstName = " Sample ";
            employed.LastName = "Student ";
            employed.sayName();
            Console.ReadLine();

        }
    }
}
