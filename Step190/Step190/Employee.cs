﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step190
{
    public class Employee<T>
    {
        public List<T> Thing { get; set; }
    }
}
