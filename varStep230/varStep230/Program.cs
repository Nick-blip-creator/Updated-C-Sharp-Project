using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace varStep230
{
    class Program
    {
        static void Main(string[] args)
        {
            const string nickName = "Nick";
            Console.WriteLine(nickName);
            var newName = new Person("Nick");
            Console.WriteLine(newName);
            Console.Read();
        }
    }
}
