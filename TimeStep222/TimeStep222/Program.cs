using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeStep222
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            int userInput = Convert.ToInt32(Console.ReadLine());
            DateTime date2 = now.AddHours(userInput);
            Console.WriteLine(date2);
            
            Console.Read();
        }
    }
}
