using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


        // 49. Group Anagrams
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {

            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            foreach (string s in strs)
            {
                string srt = new string(s.OrderBy(s => s).ToArray());

                if (!map.ContainsKey(srt))
                    map[srt] = new List<string>();

                map[srt].Add(s);
            }

            return map.Values.ToList<IList<string>>();
        }


        // 347. Top K Frequent Elements
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (!map.ContainsKey(num))
                    map[num] = 0;

                map[num]++;
            }

            var srt = map.OrderByDescending(x => x.Value).ToList(); 

            int[] arr = new int[k];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = srt[i].Key;
            }

            return arr;
        }

    }
}
