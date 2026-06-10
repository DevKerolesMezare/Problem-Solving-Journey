using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Arrays
{
    internal class Product_of_Array_Except_Self
    {

        //238. Product of Array Except Self
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;

            int[] Prefix = new int[n];
            int[] Suffix = new int[n];
            int[] result = new int[n];

            Prefix[0] = 1;
            Suffix[n - 1] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                Prefix[i] = Prefix[i - 1] * nums[i-1];
            }

            for (int i = n - 2; i >= 0; i--)
            {
                Suffix[i] = Suffix[i + 1] * nums[i + 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = Prefix[i] *  Suffix[i];
            }

            return result;
        }


        //nums =  [1,  2,  3, 4]
        //Prefix = [1,  1,  2, 6]
        //Suffix = [24, 12, 4, 1]
        /*static*/ void Main()
        {
            int[] arr = new int[] {1,2,3,4 };

            int[] Prefix = new int[arr.Length];
            int[] Suffix = new int[arr.Length];

            int n = arr.Length -1;

            Prefix[0] = 1;
            Suffix[n] = 1;


            for (int i = 1; i < arr.Length; i++)
            {
                Prefix[i] = Prefix[i - 1] * arr[i - 1];
            }

            for (int i = n - 1 ; i >= 0 ; i--)
            {
                Suffix[i] = Suffix[i + 1] * arr[i + 1];
            }

            Console.WriteLine(string.Join(" , ", Prefix));
            Console.WriteLine(string.Join(" ,", Suffix));

        }
    }
}
