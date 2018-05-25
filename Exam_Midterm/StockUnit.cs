using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Midterm
{
    public class StockUnit
    {
        protected string description;
        protected double retailPrice;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double RetailPrice
        {
            get { return retailPrice; }
            set { retailPrice = value; }
        }

        public override string ToString()
        {
            return description;
        }
    }
}
