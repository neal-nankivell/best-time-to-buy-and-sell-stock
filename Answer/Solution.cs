using System;

namespace Answer
{
    public class Solution
    {
        /*
        Say you have an array for which the ith element is the price
        of a given stock on day i.

        If you were only permitted to complete at most one
        transaction (i.e., buy one and sell one share of the stock),
        design an algorithm to find the maximum profit.

        Note that you cannot sell a stock before you buy one.
         */
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                var buyPrice = prices[i];
                for (int j = i + 1; j < prices.Length; j++)
                {
                    var sellPrice = prices[j];

                    var profit = sellPrice - buyPrice;

                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }

            return maxProfit;
        }
    }
}
