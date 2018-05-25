using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Midterm
{
    public class SodaMachine
    {
        Dictionary<string, List<StockUnit>> inventory;
        Dictionary<double, List<Money>> till;
        double tillBalance;
        double[] tillSlots;

        public SodaMachine()
        {
            tillSlots = new double[] { Quarter.Value, Dime.Value, Nickel.Value, Penny.Value };
            inventory = new Dictionary<string, List<StockUnit>>();
            till = new Dictionary<double, List<Money>>();
            for(int i = 0; i < tillSlots.Length; i++)
            {
                till.Add(tillSlots[i], new List<Money>());
            }
        }

        public void AddCoin (List<Coin> coins)
        {
            for(int i = 0; i < coins.Count; i++)
            {
                till[coins[i].Worth].Add(coins[i]);
                tillBalance += coins[i].Worth;
            }
        }

        public void AddInventory(List<StockUnit> items)
        {
            for(int i = 0; i < items.Count; i++)
            {
                if (!inventory.ContainsKey(items[i].Description))
                {
                    inventory.Add(items[i].Description, new List<StockUnit>());
                }
                inventory[items[i].Description].Add(items[i]);
            }
        }

        private bool CanMakeChange(double changeDue)
        {
            // Change all values into ints, as double caused issues (0.75 - 0.60 was equaling 0.15000000000002)
            int changeSum = 0;
            int changeDueInt = Convert.ToInt32(Math.Floor(changeDue * 100.0));

            if (tillBalance*100 > changeDueInt && changeSum < changeDueInt)
            {
                for (int i = 0; changeSum < changeDueInt && i < tillSlots.Length; i++)
                {
                    int numberCoinsNeeded = Convert.ToInt32(Math.Floor(Convert.ToDouble((changeDueInt - changeSum) / Convert.ToInt32(Math.Floor(tillSlots[i] * 100.0)))));
                    int numberCoinsInTill = till[tillSlots[i]].Count;
                    if(numberCoinsNeeded < numberCoinsInTill)
                    {
                        changeSum += numberCoinsNeeded * Convert.ToInt32(Math.Floor(tillSlots[i] * 100.0));
                    }
                    else
                    {
                        changeSum += numberCoinsInTill * Convert.ToInt32(Math.Floor(tillSlots[i] * 100.0));
                    }
                }
            }
            return changeDueInt == changeSum;
        }

        private void GetChange(List<Money> moneyExchange, double changeDue)
        {
            double changeSum = 0;
            
            for(int i = 0; changeSum < changeDue && i < tillSlots.Length; i++)
            {
                int numberCoinsNeeded = Convert.ToInt32(Math.Floor((Math.Floor(changeDue * 100) - Math.Floor(changeSum * 100)) / Math.Floor(tillSlots[i] * 100)));
                int numberCoinsInTill = till[tillSlots[i]].Count;
                while(numberCoinsNeeded > 0 && numberCoinsInTill > 0)
                {
                    moneyExchange.Add(till[tillSlots[i]][0]);
                    changeSum += till[tillSlots[i]][0].Worth;
                    till[tillSlots[i]].RemoveAt(0);
                    numberCoinsInTill--;
                    numberCoinsNeeded--;
                }
            }

        }

        public double GetRetailPrice(string itemDescription)
        {
            return inventory[itemDescription][0].RetailPrice;
        }

        public bool isItemInStock(string itemDescription)
        {
            return inventory[itemDescription].Count > 0;
        }

        private void ReceivePayment(List<Money> payment)
        {
            while(payment.Count > 0)
            {
                till[payment[0].Worth].Add(payment[0]);
                payment.RemoveAt(0);
            }
        }

        private double SumMoney(List<Money> money)
        {
            double sum = 0;

            for(int i = 0; i < money.Count; i++)
            {
                sum += money[i].Worth;
            }

            return sum;
        }

        public StockUnit SellTranscation(string itemDescription, List<Money> moneyExchange)
        {
            if (isItemInStock(itemDescription))
            {
                double amountPaid = SumMoney(moneyExchange);
                double amountDue = GetRetailPrice(itemDescription);
                double changeDue = ((Math.Floor(amountDue * 100) - Math.Floor(amountPaid * 100)) / 100) * -1;
                if (CanMakeChange(changeDue))
                {
                    ReceivePayment(moneyExchange);
                    GetChange(moneyExchange, changeDue);
                    return Vend(itemDescription);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private StockUnit Vend (string itemDescription)
        {
            StockUnit item;

            if (isItemInStock(itemDescription))
            {
                item = inventory[itemDescription][0];
                inventory[itemDescription].RemoveAt(0);
                return item;
            }
            else
            {
                return null;
            }
        }
    }
}
