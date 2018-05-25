using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Midterm
{
    public abstract class Money
    {
        double worth;

        public Money(double worth)
        {
            this.worth = worth;
        }

        public double Worth
        {
            get { return worth; }
        }

        public override string ToString()
        {
            return worth.ToString("C2");
        }
    }
}
