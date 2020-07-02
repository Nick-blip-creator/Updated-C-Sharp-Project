using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            Employee<string> employeeNumber = new Employee<string>();

            employee.Things = "peach";
            employeeNumber.Things = 484;

            Console.WriteLine(employee.Things);
            Console.WriteLine(employeeNumber.Things);



        }
    }
}
