using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate? ");
            float hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hourlyRate);
            Console.WriteLine("Hours worked per week? ");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hoursWorked);
            double total1 = hourlyRate * hoursWorked;


            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate? ");
            float secondHourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(secondHourlyRate);
            Console.WriteLine("Hours worked per week? ");
            int secondHoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(secondHoursWorked);
            double total2 = secondHoursWorked * secondHourlyRate * 52;

            Console.WriteLine("Annual Salary of Person 1: ");
            Console.WriteLine(hoursWorked * hourlyRate * 52);

            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(secondHoursWorked * secondHourlyRate * 52);

            Console.WriteLine("Does Person 1 make more money than Person 2? ");

            Console.WriteLine(total1 < total2);

            Console.ReadLine();


        }
    }
}
