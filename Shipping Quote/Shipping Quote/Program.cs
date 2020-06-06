using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below ");
            Console.WriteLine("Please enter the package weight: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package width: ");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height: ");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            int dimension = packageHeight * packageLength;

            if (dimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }
            int estimatedCost = dimension * packageWeight / 100;
            Console.WriteLine("Your estimateed total for shipping this package is: $" + estimatedCost) ;
            Console.WriteLine("Thank you");



            Console.Read();
        }
    }
}
