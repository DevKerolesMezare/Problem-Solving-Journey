using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Arrays
{
    public class Two_Sum_Pattern
    {

        // مرحله الاولي ترجع هل موجود مكمل ام لا 
        static bool my_FirstSumPattern(int[] arr, int target)
        {
            int currnet = 0;
            int nedded = target;

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i< arr.Length; i++)
            {
                currnet = arr[i];
                nedded = target - currnet;
                
                if (map.ContainsKey(nedded))
                    return true;

                map[currnet] = i;
            }

            return false;
        }


        // مرحله الاولي ترجع هل موجود مكمل ام لا اذا مموجود نرجع الاماكن
        static int[] MyTwoSum(int[] arr, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int currnet = arr[i];

                int ned = target - currnet;

                if (map.ContainsKey(ned))
                    return new int[] {map[ned] ,i};    // return the indexes      

                map[currnet] = i;       // نخزن العناصر ونزخن الكي هيا القيمه علشان نوصلها بي log n 
            }

            return new int[] { }; // لو غير موجود نرجع اري فارغ
        }


        // 217. Contains Duplicate
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                    return true;

                map[nums[i]] = i;
            }
      
            return false;
        }


        //242. Valid Anagram
        //مش الافضل لانه بيديني
        //o(n log n)
        public bool IsAnagram(string s, string t)
        {
            return (s.OrderBy(x => x).SequenceEqual(t.OrderBy(c => c)));
        }



        // 167. Two Sum II - Input Array Is Sorted
        public int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                int added = target - current;

                if (map.ContainsKey(added))
                    return new int[] { map[added] + 1, i + 1 };


                map[current] = i;
            }

            return new int[] { };
        }

        static void Main()
        {
            int[] arr = new int[] {  5, 2 ,3 , 3, 6 };

            Console.WriteLine("Is Find?: " + my_FirstSumPattern(arr , 5));
            Console.WriteLine("Indexes?: " + string.Join(" , ", MyTwoSum(arr , 5)));
        }
    }
}
