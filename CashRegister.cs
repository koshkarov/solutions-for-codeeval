using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CashRegister
{
    class Program
    {

        static string greedy(decimal price, decimal cash)
        {
            var coins = new Dictionary<string, decimal>()
            {
                {"PENNY", 0.01m},
                {"NICKEL", 0.05m},
                {"DIME", 0.10m},
                {"QUARTER", 0.25m},
                {"HALF DOLLAR", 0.50m},
                {"ONE", 1.00m},
                {"TWO", 2.00m},
                {"FIVE", 5.00m},
                {"TEN", 10.00m},
                {"TWENTY", 20.00m},
                {"FIFTY", 50.00m},
                {"ONE HUNDRED", 100.00m}
            };

            // Do we need epsilon here?
            int change = (int)((cash - price) * 100m);
            List<string> result = new List<string>();

            foreach (var coin in coins.OrderByDescending(i => i.Value))
            {
                int coinValue = (int)(coin.Value * 100);

                if (coinValue <= change)
                {
                    int num = change / coinValue;
                    change = change - coinValue * num;
                    result.AddRange(Enumerable.Repeat(coin.Key, num));
                }

                if (change == 0)
                    break;
            }

            // Return the string with coins in change
            return String.Join(",", result);

        }

        static void Main(string[] args)
        {

            {
                using (StreamReader reader = File.OpenText(args[0]))

                    while (!reader.EndOfStream)
                    {
                        string[] data = reader.ReadLine().Split(';').ToArray();

                        decimal price = Decimal.Parse(data[0]);
                        decimal cash = Decimal.Parse(data[1]);

                        // Cover ZERO and ERROR cases, otherwise call greedy to calculate change

                        Console.WriteLine(cash - price < 0 ? "ERROR" : (cash - price == 0 ? "ZERO" : greedy(price, cash)));
                    }

                Console.ReadKey();
            }
        }
    }
}
