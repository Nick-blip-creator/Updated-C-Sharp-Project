using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step131
{
    class Program
    {
        static void Main()
        {
            string[] strArray = { "Kobe", "Lebron", "Shaq", "Kemba", "Damien" };
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Please enter an index from the list: \n(Whole number between 0-4)");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 0 && choice <= 4)
                {
                    Console.WriteLine("\nYou chose: " + strArray[choice] + "\n");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Index entered is not valid.");
                }
            }

            int[] intArray = { 12, 23, 34, 45, 56 };
            bool isValid1 = false;
            while (!isValid1)
            {
                Console.WriteLine("Please enter an index from the list: \n(Whole number between 0-4)");
                int choice1 = Convert.ToInt32(Console.ReadLine());
                if (choice1 >= 0 && choice1 <= 4)
                {
                    Console.WriteLine("\nYou chose: " + intArray[choice1] + "\n");
                    isValid1 = true;
                }
                else
                {
                    Console.WriteLine("Index entered is not valid.");
                }
            }


            List<string> strList = new List<string>();
            strList.Add("Giancarlo");
            strList.Add("MichaelAngelo");
            strList.Add("Shaq");
            strList.Add("Shazamm");
            strList.Add("Jackie Chan");
            strList.Add("Rick James");

            bool isValid2 = false;
            while (!isValid2)
            {
                Console.WriteLine("Please enter an index from the list: \n(Whole number between 0-5)");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 >= 0 && choice2 <= 5)
                {
                    Console.WriteLine("\nYou chose: " + strList[choice2] + "\n");
                    isValid2 = true;
                }
                else
                {
                    Console.WriteLine("Index entered is not valid.");
                }
            }
            Console.ReadLine();




        }
    }
}