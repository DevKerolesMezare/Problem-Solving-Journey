using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.HashMap____HashSet
{
    internal class Valid_Anagram___Group_Anagrams
    {
        //242. Valid Anagram
        public bool IsAnagram(string s, string t)
        {
            if (t.Length != s.Length)
                return false;

            Dictionary<char, int> map = new();

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


        //49. Group Anagrams
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

    }
}
