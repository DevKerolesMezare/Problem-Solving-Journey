using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemSolvingPractice.Strings
{
    internal class Valid_Palindrome
    {
        //125. Valid Palindrome
        public bool IsPalindrome(string s)
        {
            string result = new string(
            s.Where(char.IsLetterOrDigit).ToArray()).ToLower();      // مش الافضل لاننا بنمشي اكثر من مره علي 
                                                                     // string الواحد
            char[] arr = result.ToCharArray();

            int L = 0;
            int R = arr.Length -1;

            while (L < R)
            {
                if (arr[L] != arr[R])
                    return false;

                L++;
                R--;
            }

            return true;
        }

        //125. Valid Palindrome
        // مساعده بسيطه من AI
        public bool IsPalindrome_2(string s)
        {
            int L = 0;
            int R = s.Length -1;

            while (L < R)
            {
                while (L < R && !char.IsLetterOrDigit(s[L]))
                    L++;

                while (L < R && !char.IsLetterOrDigit(s[R]))
                    R--;

                if (char.ToLowerInvariant(s[L]) != char.ToLowerInvariant(s[R]))
                    return false;

                L++;
                R--;
            }

            return true;
        }
    }
}
