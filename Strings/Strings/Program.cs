using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            string firstName = "Nick ";
            string lastName = "Walker ";
            string birthPlace = "Los Angeles";
            string personData = firstName + lastName + birthPlace;
            Console.WriteLine(personData);
            string upperCased = "Hi People ";
            Console.WriteLine(upperCased.ToUpper());

            StringBuilder sb = new StringBuilder();

            sb.Append("Hey it's Nick ");
            sb.Append("Hope you're having a great day! ");
            sb.Append("Hope the instructor passes this assignment! ");
            sb.Append("This is enough lines for a paragraph, I think. ");

            Console.WriteLine(sb);
            
            Console.Read();
        }
    }
}
