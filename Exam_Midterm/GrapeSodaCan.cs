using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Midterm
{
    class GrapeSodaCan : SodaCan
    {
        public GrapeSodaCan() : base(Name, 0.60)
        {

        }

        public static string Name
        {
            get { return "Grape Soda (12-oz can)"; }
        }
    }
}
