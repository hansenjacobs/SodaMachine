using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Midterm
{
    class OrangeSodaCan : SodaCan
    {
        public OrangeSodaCan() : base(Name, 0.35)
        {

        }

        public static string Name
        {
            get { return "Orange Soda (12-oz can)"; }
        }
    }
}
