using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Three
{
    public class division
    {
        public int addition(int add)
        {
            int total = add + 10;
            return total;
        }
        public int subtraction(int subtract)
        {
            Console.WriteLine("Pick a number to subtract by 50 ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int subtractionTotal = userInput - subtract;
            return subtractionTotal;
        }
        public int multipication(int multiply)
        {
            Console.WriteLine("Pick a number to multiply by 50 ");
            int usersInput = Convert.ToInt32(Console.ReadLine());
            int multiplicationTotal = usersInput * multiply;
            return multiplicationTotal;
        }
    }
}
