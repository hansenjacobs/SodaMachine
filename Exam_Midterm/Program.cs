using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            SodaMachine sodaMachine = SodaMachineSetup.New();

            Console.WriteLine($"Is {GrapeSodaCan.Name} in stock? {sodaMachine.isItemInStock(GrapeSodaCan.Name)}");

            List<Money> myPayment = new List<Money>();
            myPayment.Add(new Quarter());
            myPayment.Add(new Quarter());
            myPayment.Add(new Quarter());
            StockUnit myPurchase = sodaMachine.SellTranscation(GrapeSodaCan.Name, myPayment);
            Console.WriteLine(myPurchase.Description);
            Console.Read();
        }
    }
}
