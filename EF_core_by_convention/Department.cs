﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_by_convention
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
