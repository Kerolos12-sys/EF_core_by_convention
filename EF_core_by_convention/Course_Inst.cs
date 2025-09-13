using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_by_convention
{
    internal class Course_Inst
    {
        public int ID { get; set; }
        public int Inst_ID { get; set; }
        
        public string Evaluate { get; set; }
        public int Course_ID { get; set; }

    }
}
