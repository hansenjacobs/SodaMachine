using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Midterm
{
    public static class SodaMachineSetup
    {
        public static SodaMachine New()
        {
            SodaMachine sodaMachine = new SodaMachine();
            List<Coin> till = new List<Coin>();
            List<StockUnit> items = new List<StockUnit>();
            
            // Create 20 quarters
            for(int i = 0; i < 20; i++)
            {
                till.Add(new Quarter());
            }
            // Create 10 dimes
            for (int i = 0; i < 10; i++)
            {
                till.Add(new Dime());
            }
            // Create 20 nickels
            for (int i = 0; i < 20; i++)
            {
                till.Add(new Nickel());
            }
            // Create 50 pennies
            for (int i = 0; i < 50; i++)
            {
                till.Add(new Penny());
            }
            sodaMachine.AddCoin(till);
            
            // Create 20 grape sodas
            for (int i = 0; i < 20; i++)
            {
                items.Add(new GrapeSodaCan());
            }
            // Create 20 oragne sodas
            for (int i = 0; i < 20; i++)
            {
                items.Add(new OrangeSodaCan());
            }
            // Create 20 lemon sodas
            for (int i = 0; i < 20; i++)
            {
                items.Add(new LemonSodaCan());
            }
            sodaMachine.AddInventory(items);

            return sodaMachine;
        }
    }
}
