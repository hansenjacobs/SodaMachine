using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Midterm
{
    public class Quarter : Coin
    {
        public Quarter() : base(Value)
        {

        }

        public static double Value
        {
            get { return 0.25; }
        }
    }
}
