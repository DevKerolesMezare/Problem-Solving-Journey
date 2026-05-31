using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Arrays
{
    public class DuplicateNumber
    {
        // Leet Code
        //217. Contains Duplicate
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> val = new HashSet<int>();

            foreach (int num in nums)
            {
                if (val.Contains(num))
                    return true;

                val.Add(num);
            }
            return false;
        }


        //219. Contains Duplicate II
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    if ((Math.Abs(i - map[nums[i]]) <= k))
                        return true;
                }
                map[nums[i]] = i;
            }
            return false;
        }



        // 242. Valid Anagram
        public bool IsAnagram(string s, string t)
        {
            if (t.Length != s.Length)
                return false;

            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                    map[s[i]]++;
                else
                    map[s[i]] = 1;
            }

            for (int i = 0; i<t.Length; i++)
            {
                if (!map.ContainsKey(t[i]))
                    return false;

                map[t[i]]--;

                if (map[t[i]] < 0)
                    return false;
            }

            foreach (var c in map)
            {
                if (c.Value  != 0)
                    return false;
            }

            return true;
        }

    }
}
