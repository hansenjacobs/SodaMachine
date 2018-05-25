using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Midterm
{
    public class Nickel : Coin
    {
        public Nickel() : base(Value)
        {

        }

        public static double Value
        {
            get { return 0.05; }
        }
    }
}
