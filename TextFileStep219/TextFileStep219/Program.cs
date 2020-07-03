using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileStep219
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            string convertedToStringUserInput = userInput.ToString();
            File.WriteAllText(@"C:\logs.txt", convertedToStringUserInput);
            string log = File.ReadAllText(@"C:\logs.txt");
            Console.WriteLine(log);
            Console.Read();
        }
    }
}
