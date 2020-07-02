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

            employeeNumber.Thing.Add(474);
            employee.Thing.Add("Nick");

            foreach (int num in employeeNumber)
            {
                Console.WriteLine(num);
            }
            foreach (string employ in employee)
            {
                Console.WriteLine(employ);
            }


            Console.Read();
        }

        
    }
}
