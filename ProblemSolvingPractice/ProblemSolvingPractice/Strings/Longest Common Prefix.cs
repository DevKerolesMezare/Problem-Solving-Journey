using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Strings
{
    internal class Longest_Common_Prefix
    {

        //14. Longest Common Prefix
        public string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            int minL = strs[0].Length;

            for (int i = 0; i < strs.Length; i++)
            {
                minL = Math.Min(minL, strs[i].Length);
            }

            for (int i = 0; i < minL; i++)
            {
                int index = i;
                char c = strs[0][i];

                for (int j = 0; j < strs.Length; j++)
                {
                    if (c != strs[j][i])
                        return result;
                }

                result += strs[0][i];
            }

            return result;
        }
    }
}
