using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Arrays
{
    public  class MissingNumber1
    {

        public int My_MissingNumber(int[] nums)
        {
            int actual = nums.Sum();
            int Exp = 0;

            for (int i = 0; i <= nums.Length; i++)
            {
                Exp += i;
            }
            return (Exp - actual);
            
        }


        // Leetcode
        // 268. Missing Number
        public int MissingNumber(int[] nums)
        {
            int result = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                result ^= i;
                result ^= nums[i];
            }
            return result;
        }


        // Leetcode
        //136. Single Number
        public int SingleNumber(int[] nums)
        {
            int result = 0;

            foreach (int num in nums)
            {
                result ^= num;         // نلغي جمميع العناصر المكرره لحد العنصر النهائي
            }
            return result;
        }


        // 389. Find the Difference
        static public char FindTheDifference(string s, string t)
        {
            char result = '\0';

            foreach (char k in s)
                result ^= k;

            foreach (char k in t)
                result ^= k;

            return result;
        }


        public /*static*/ void  Main()
        {
            string s = "kero" ,l ="krleo";

            Console.WriteLine("restul: " + FindTheDifference(s, l));

            
        }

    }
}
