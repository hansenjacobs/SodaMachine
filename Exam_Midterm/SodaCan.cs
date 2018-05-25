using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Midterm
{
    class SodaCan : StockUnit
    {
        public SodaCan(string description, double retailPrice)
        {
            this.description = description;
            this.retailPrice = retailPrice;
        }
    }
}
