using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step179
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employed = new Employee() {FirstName ="Sample", LastName="Student"};
            employed.Quit();
            Console.ReadLine();
        }
    }
}
