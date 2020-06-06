using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How old am I? ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool myAge = number == 26;

            do
            {
                switch (number)
                {
                    case 23:
                        Console.WriteLine("How old am I? ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 26:
                        Console.WriteLine("You guess right! ");
                        myAge = true;
                        break;
                    default:
                        Console.WriteLine("How old am I? ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            while (!myAge);
            Console.Read();
        }
    }
}
            
                
            
        


