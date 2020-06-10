using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input something: ");
            string carInput = Console.ReadLine();
            List<string> cars = new List<string>() { "BMW", "Ferrari", "Bentley", "Rolls Royce" };

            //Part1 
            foreach (string car in cars)
            {
                Console.WriteLine(car + " " + carInput);
            }
            //Part 2 & Part3 fixed infinite loop
            int i = 0;
            while (!true)
            {
                Console.WriteLine(i);
                i++;

            }

            //Part 4

            int number = 500;
            for (int x = number; x < 502; x++)
            {
                Console.WriteLine(x);
            }

            //Part 5
            for (int x = 0; x <= 5; x++)
            {
                Console.WriteLine(x);
            }

            //Part 6 7 8

            List<string> cities = new List<string>() { "Los Angeles", "London", "Portland", "Detroit" };
            Console.WriteLine("Enter a city to see if it appears: ");
            string cityInput = Console.ReadLine();
            bool isThere = false;

            foreach (string city in cities)
            {
                if (cityInput == city)
                {
                    Console.WriteLine("The city is here! ");
                    int index1 = cities.IndexOf(city);
                    Console.WriteLine(index1);
                    isThere = true;
                    break;
                }
            }
            if (!isThere)
            {
                Console.WriteLine("City not found.");
            }

            //Part 9
            List<string> streets = new List<string>() { "Hollywood Blvd", "Vineland", "Vineland", "Apple St" };
            Console.WriteLine("Enter a street to see if it appears: ");
            string streetInput = Console.ReadLine();
            bool isTherel = false;



            foreach (string street in streets)
            {
                if (streetInput == street)
                {
                    Console.WriteLine("The city is here! ");
                    int index1 = streets.IndexOf(street);
                    Console.WriteLine(index1);
                    isTherel = true;
                    break;
                }
            }
            if (!isTherel)
            {
                Console.WriteLine("City not found.");
            }
            Console.WriteLine("S duplicate countries. ");
            List<string> countries = new List<string>() { "Germany", "Germany", "Sweden", "Switzerland", "America" };
            List<string> newCountriesList = new List<string>();


            Console.WriteLine("Initial list of countries ...");

            foreach (string val1 in countries)
            {
                if (val1.Contains(val1))
                {
                   newCountriesList.Add(val1)
                }
                Console.WriteLine(newCountriesList.Contains(val1));

            }

        }
        Console.Read();


    }
}
    
}



        




















