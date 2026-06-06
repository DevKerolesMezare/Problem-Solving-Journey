using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Strings
{
    internal class Reverse_String
    {

        //344. Reverse String
        public void ReverseString(char[] s)
        {
            int L = 0;
            int R = s.Length - 1;

            while (L < R)
            {
                char temp = s[L];

                s[L] = s[R];
                s[R] = temp;

                L++;
                R--;
            }
        }



        //345. Reverse Vowels of a String
        public class Solution
        {
            public bool IsVowel(char c)
            {
                c = char.ToLower(c);
                return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
            }

            public string ReverseVowels(string s)
            {
                char[] arr = s.ToCharArray();

                int L = 0;
                int R = arr.Length -1;

                while (L < R)
                {
                    while (L < R && !IsVowel(arr[L]))
                        L++;

                    while (L < R && !IsVowel(arr[R]))
                        R--;

                    char temp = arr[L];
                    arr[L] = arr[R];
                    arr[R] = temp;

                    L++;
                    R--;
                }

                return new string(arr);
            }
        }


    }
}
