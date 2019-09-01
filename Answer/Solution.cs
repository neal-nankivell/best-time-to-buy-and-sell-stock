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

            int bestBuyPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                int sellPrice = prices[i];

                int profit = sellPrice - bestBuyPrice;

                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }

                if (sellPrice < bestBuyPrice)
                {
                    bestBuyPrice = sellPrice;
                }
            }

            return maxProfit;
        }
    }
}
