using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Strings
{
    internal class String_Compression
    {
        // حل اول
        //443. String Compression
        public int Compress(char[] chars)
        {
            if (chars.Length == 1)
                return 1;

            char c = chars[0];
            int count = 1;
            int write_index = 0;

            for (int i = 1; i < chars.Length; i++)
            {
                if (c == chars[i])
                    count++;
                else
                {
                    if (count > 1)
                    {
                        chars[write_index++] = c;
                        if (count > 9)
                        {
                            foreach (char digit in count.ToString())
                            {
                                chars[write_index++] = digit;
                            }
                        }
                        else
                        {
                            chars[write_index++] = (char)(count +'0');
                        }
                    }
                    else
                    {
                        chars[write_index++] = c;
                    }
                    c = chars[i];
                    count = 1;
                }
            }

            if (count > 1)
            {
                chars[write_index++] = c;
                if (count > 9)
                {
                    foreach (char digit in count.ToString())
                    {
                        chars[write_index++] = digit;
                    }
                }
                else
                {
                    chars[write_index++] = (char)(count +'0');
                }
            }
            else
            {
                chars[write_index++] = c;
            }

            return write_index;
        }


        // 2 
        public int Compress2(char[] chars)
        {
            int write = 0;
            int count = 1;

            for (int i = 1; i <= chars.Length; i++)
            {
                if (i < chars.Length && chars[i] == chars[i - 1])
                {
                    count++;
                }
                else
                {
                    chars[write++] = chars[i - 1];

                    if (count > 1)
                    {
                        foreach (char digit in count.ToString())
                        {
                            chars[write++] = digit;
                        }
                    }

                    count = 1;
                }
            }

            return write;
        }
    }
}
