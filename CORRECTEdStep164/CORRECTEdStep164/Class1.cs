using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORRECTEdStep164
{
    class Class1
    {
        public int addition(int add)
        {
            int total = add + 10;
            return total;
        }
        public int addition(decimal add)
        {
            decimal fullTotal = add + 10.9m;
            int result = Convert.ToInt32(fullTotal);
            return result;
        }
        public int addition(string add)
        {
            int x = Convert.ToInt32(add);
            x = x + 5;
            return x;
        }
    }
}
