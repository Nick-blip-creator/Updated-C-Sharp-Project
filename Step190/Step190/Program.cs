using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step190
{
     class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            Employee<int> employeeNumber = new Employee<int>();
            employeeNumber.Thing = new List<int>();
            employee.Thing = new List<string>();


            employeeNumber.Thing.Add(474);
            employee.Thing.Add("Nick");

            foreach (int num in employeeNumber.Thing)
            {
                Console.WriteLine(num);
            }
            foreach (string employ in employee.Thing)
            {
                Console.WriteLine(employ);
            }


            Console.Read();
        }

        
    }
}
