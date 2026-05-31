using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Arrays
{
    internal class Maximum_Subarray
    {
        /// DONE...! Kadane Algorithm 
        ///  Kadaneتم هيا هيا فكره ال
        ///  

        // 53. Maximum Subarray
        public int MaxSubArray(int[] nums)
        {
            int current = 0;
            int max = int.MinValue;

            foreach (int num in nums)
            {
                current = Math.Max(num, current + num);
                max = Math.Max(max, current);
            }
            return max;
        }
    }
}
