using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Midterm
{
    class LemonSodaCan : SodaCan
    {
        public LemonSodaCan() : base(Name, 0.06)
        {

        }

        public static string Name
        {
            get { return "Lemon Soda (12-oz can)"; }
        }
    }
}
