using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_by_convention
{
    internal class Stud_Course
    {
        public int ID { get; set; }
        public int Stud_ID { get; set; }

        public int Course_ID { get; set; }

        public int Grade { get; set; }
    }
}
