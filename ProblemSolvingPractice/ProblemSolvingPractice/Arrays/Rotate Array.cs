using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Arrays
{
    internal class Rotate_Array
    {

        //189. Rotate Array
        //
        public void Rotate(int[] nums, int k)
        {
            int[] newArr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int newIndex = i + k;

                newIndex = newIndex % nums.Length;

                newArr[newIndex] = nums[i];
            }
            for (int i = 0; i< nums.Length; i++)
            {
                nums[i] = newArr[i];
            }
        }



        // حل اخر لاكنه سئ
        public void Rotate2(int[] nums, int k)
        {
            int[] newArr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int newIndex = i + k;

                if (newIndex >= nums.Length)
                {
                    while (newIndex >= nums.Length)
                    {
                        newIndex -= nums.Length;
                    }
                }

                newArr[newIndex] = nums[i];
            }

            for (int i = 0; i< nums.Length; i++)
            {
                nums[i] = newArr[i];
            }
        }

    }
}
