﻿using System;
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
            return (employee1.ID == employee2.ID);

        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return (employee1.ID != employee2.ID);
        }
        
    }
}
