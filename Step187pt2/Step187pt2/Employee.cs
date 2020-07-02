using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step187pt2
{
    class Employee
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
        public void getID()
        {
            Console.WriteLine(ID);
        }
    }
}
