using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Arrays
{
    public class KadaneAlgorithm
    {

        // اجابتي بناء علي فهم الشرح بدون ما اشوف اي كود
        static int myKadaneAlgorithm(int[] arr)
        {
            int max = arr[0];
            int current = arr[0];
            for (int i = 1; i<arr.Length; i++)
            {
                // مشكلتها بتفشل لو العناصر كلها كانت سلبيه في الارري 
                // وكمان بيخترعلي سلسله وهميه صفر وهو حل مش مفضل 
                // وكمان في  ليت كود 53 واجهتني المشكله لما جربت اكتب الطريقه دي بسب اني
                // [-2 , 1]
                // المفروض الناتج يطلع 1 مش صفر

                 current += arr[i];

                if (current < 0)
                    current = 0;

                if (current > max)
                    max = current;
            }

            return max;
        }


        // الاحترافي 

        // لانه بيجاوبني علي سوال 
        // هل الأفضل أن أبدأ سلسلة جديدة؟
        //أم أكمل القديمة؟  
        static int Kadane(int[] arr)
        {
            int current = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                current = Math.Max(arr[i], current + arr[i]);

                max = Math.Max(max, current);
            }

            return max;
        }


        // Done! LeetCode
        //53. Maximum Subarray
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int current = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                current = Math.Max(nums[i], current + nums[i]);

                max = Math.Max(max, current);
            }

            return max;
        }


        // 121. Best Time to Buy and Sell Stock
        public int MaxProfit(int[] prices)
        {
            int minPrice = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (minPrice > prices[i])
                    minPrice = prices[i];

                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }
            return maxProfit;
        }

        static void Main()
        {
            int[] arr = new int[] { 2, -1, 3, -4 , 5 };

            Console.WriteLine("The Best SubArray: " + myKadaneAlgorithm(arr));
        }

    }
}
