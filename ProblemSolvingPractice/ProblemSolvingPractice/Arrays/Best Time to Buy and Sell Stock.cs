using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Arrays
{
    internal class Best_Time_to_Buy_and_Sell_Stock
    {
        // DONE>>!
        // حليتها من قبل

        //121. Best Time to Buy and Sell Stock
        public int MaxProfit(int[] prices)
        {
            int minPrice = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                int CurrentPrice = prices[i] - minPrice;
                minPrice = Math.Min(minPrice, prices[i]);

                if (CurrentPrice > maxProfit)
                    maxProfit = CurrentPrice;
            }
            return maxProfit;
        }
    }
}
