using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.HashMap____HashSet
{
    internal class Two_Sum
    {
        //1. Two Sum
        // easy
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                    return new[] { i, map[nums[i]] };

                int needed = target - nums[i];
                map[needed] = i;
            }

            return null;
        }


        //349. Intersection of Two Arrays
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> vlu = new();
            HashSet<int> inters = new();

            foreach (int n in nums1)
            {
                if (!vlu.Contains(n))
                    vlu.Add(n);
            }

            foreach (int n in nums2)
            {
                if (vlu.Contains(n))
                  inters.Add(n); 
            }
            return inters.ToArray();
        }

        //350. Intersection of Two Arrays II
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> map = new();
            List<int> inters = new();

            foreach (int n in nums1)
            {
                if (map.ContainsKey(n))
                    map[n]++;
                else
                    map[n] = 1;
            }

            foreach (int n in nums2)
            {
                if (map.ContainsKey(n) && map[n] > 0)
                {
                    inters.Add(n);
                    map[n]--;
                }
            }

            return inters.ToArray();
        }

    }
}
