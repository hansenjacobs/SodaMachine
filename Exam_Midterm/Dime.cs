using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Midterm
{
    public class Dime : Coin
    {
        public Dime() : base(Value)
        {

        }

        public static double Value
        {
            get { return 0.10; }
        }
    }
}
