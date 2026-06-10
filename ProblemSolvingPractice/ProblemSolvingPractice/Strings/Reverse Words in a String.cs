using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Strings
{

    internal class Reverse_Words_in_a_String
    {
        //151. Reverse Words in a String
        // o(n)
        public string ReverseWords(string s)
        {
            string word = "";
            Stack<string> words = new();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                    word+=s[i];
                else
                {
                    if (word != "")
                    {
                        words.Push(word);
                        word ="";
                    }
                }
            }
            if (word != "")
            {
                words.Push(word);
                word ="";
            }

            return string.Join(" ", words);
        }
    }
}
