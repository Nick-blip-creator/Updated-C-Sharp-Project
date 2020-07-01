using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step169
{
    class Class1
    {
        public void intOutput(int userInput)
        {
            int total = userInput / 2;
            Console.WriteLine(total);
        }
        public void voidMethod(int userInt, out int outInt)
        {
            outInt = userInt / 2;
        }

    }
}
