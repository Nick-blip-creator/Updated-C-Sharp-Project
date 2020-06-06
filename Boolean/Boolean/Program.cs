using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? ");
            Console.WriteLine("Please answer true or false");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(dui);
            Console.WriteLine("How many speeding tickets do you have? ");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified? ");
            Console.WriteLine(age > 15 && dui == false && speedingTickets < 3);
            Console.ReadLine();
        }
    }
}
