using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.HashMap____HashSet
{
    internal class Frequency_Count
    {
        //1207. Unique Number of Occurrences
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> map = new();

            foreach (int i in arr)
            {
                if (map.ContainsKey(i))
                    map[i]++;
                else
                    map[i] = 1;
            }

            HashSet<int> set = new();
            foreach (int count in map.Values)
            {
                if (!set.Add(count))
                    return false;
            }

            return true;
        }


        //383. Ransom Note
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
                return false;

            Dictionary<int, int> map = new();

            foreach (int i in ransomNote)
            {
                if (map.ContainsKey(i))
                    map[i]++;
                else
                    map[i] = 1;
            }

            foreach (int i in magazine)
            {
                if (map.ContainsKey(i))
                {
                    if (map[i]  > 0)
                        map[i]--;
                }
            }

            foreach (int n in map.Values)
            {
                if (n != 0)
                    return false;
            }

            return true;
        }


        //451. Sort Characters By Frequency
        public string FrequencySort(string s)
        {
            Dictionary<char, int> map = new();

            foreach (char c in s)
            {
                if (map.ContainsKey(c))
                    map[c]++;
                else
                    map[c] = 1;
            }

            var sorted = map.OrderByDescending(x => x.Value);

            StringBuilder sb = new();

            foreach (var item in sorted)
            {
                sb.Append(item.Key, item.Value);
            }

            return sb.ToString();
        }
    }
}

