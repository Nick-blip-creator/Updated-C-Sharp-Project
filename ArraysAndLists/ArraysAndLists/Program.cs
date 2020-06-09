using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select an index of the array ");
            string[] city = { "Los Angeles", "London", "Portland", "Miami" };
            int input = int.Parse(Console.ReadLine());
            if (input > city.Length)
            {
                Console.WriteLine("This doesn't exist ");
            }
            Console.WriteLine("The city is : " + city[input]);

            Console.WriteLine("Select an index for a number ");
            int[] numbers = {1, 2, 3, 4, 5, 6 };
            int numberImput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is : " + numbers[numberImput]);

            
            Console.Read();


        }
    }
}
