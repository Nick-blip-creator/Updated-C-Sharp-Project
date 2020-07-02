using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>() { "Nick Walker 2", "Tony Fred 3 ", "Joe James 4", "Joe Joseph 5", "Mike Trout 6", "Jr Smith 7", "Kobe Bryant 8", "Lebron James 9", "Kevin Durant 10", "Susan Surrandon 11" };
            List<string> newNameList = new List<string>();

            foreach (string name in nameList)
            {
                if (name == "Joe")
                {
                    newNameList.Add(name);
                    Console.WriteLine(name);

                }
            }
            Console.Read();
          }
       }
    }

