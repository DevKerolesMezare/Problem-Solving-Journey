using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Arrays
{
    internal class arrPrefixSum
    {
        static int[] myFirstPrefixArray(int[] arr)
        {
            for (int i = 1; i < arr.Length;i++)
            {
                arr[i] += arr[i - 1];
            }
            return arr; 
        }

        static int SumRange(int[] prefix, int L, int R)
        {
            if (L==0)
                return prefix[R];

            return prefix[R] - prefix[L - 1];
        }

        // LetCode  75    1732. Find the Highest Altitude
        public int LargestAltitude(int[] gain)
        {
            int current = 0, max = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                current += gain[i];

                if (current > max)
                    max = current;
            }
            return max;
        }

        // 2  724. Find Pivot Index
        public int PivotIndex(int[] nums)
        {
            int totalSum = nums.Sum(), leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int R = totalSum - leftSum - nums[i];
                if (R == leftSum)
                    return i;

                leftSum += nums[i];
            }
            return -1;
        }

        //1480. Running Sum of 1d Array
        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i -1];
            }
            return nums;
        }


        // 2574. Left and Right Sum Differences
        static public int[] LeftRightDifference(int[] nums)
        {
            int n = nums.Length;

            int total = nums.Sum();
            int[] answer = new int[n];

            int L = 0;
            for (int i = 0; i < n; i++)
            {
                int R = total - L - nums[i];
                answer[i] = Math.Abs(L - R);
                L += nums[i];
            }

            return answer;
        }


        //303. Range Sum Query - Immutable
        public class NumArray
        {
            public int[] prefix;

            public NumArray(int[] nums)
            {
                prefix = new int[nums.Length];

                prefix[0] = nums[0];
                for (int i = 1; i< nums.Length; i++)
                {
                    prefix[i] = prefix[i - 1] + nums[i];
                }
            }

            public int SumRange(int left, int right)
            {
                if (left == 0)
                    return prefix[right];

                return prefix[right] - prefix[left - 1];
            }
        }

        static void Main()
        {
            int[] arr = new int[]{ 10, 4, 8, 3 };

            //int[] prefix = myFirstPrefixArray(arr);

            //Console.WriteLine(SumRange(prefix, 2, 4));
            //Console.WriteLine(SumRange(prefix, 1, 3));
            //Console.WriteLine(SumRange(prefix, 0, 2));


            foreach (int i in LeftRightDifference(arr))
            {
                Console.Write(i + " <--> ");
            }
        }

    }
}
