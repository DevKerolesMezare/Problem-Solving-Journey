using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Arrays
{
    public class arrMajorityElement
    {

        // المطلوب إيجاد عنصر يتكرر أكثر من نصف حجم المصفوفة
        // number > n\2
        static public int myMajorityElement(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {             
                    map[arr[i]] += 1;
                }
                else
                {
                    map[arr[i]] = 1;
                }

                if (map[arr[i]] > (arr.Length / 2))  // لو العنصر ظهر أكتر من نصف المصفوفة
                {
                    return arr[i];
                }
            }
            return -1; 
        }


        // هجرب الحل بطريقه اخري 
        static public int myMajorityElement2(int[] arr)
        {
            int candidate = 0;
            int count = 0;

            for (int i = 0; i <arr.Length; i++)
            {
                if (count == 0)
                {
                    candidate = arr[i];
                }

                if (candidate == arr[i])
                    count++;
                else
                    count--;
            }

            return candidate;
        }


        //217. Contains Duplicate
        // حليتها في الtwo sum pattern 
         //  بس دي طريقه افضل لانها مكناش محتاجين الدكشنري والمساحه الزيادة
         // وكنا ممكن نحله  بي هاش سيت لاننا مش محتاجين غير تخزين عناصر غير مكرره فقط واذا وجدنا العنصر 
         // يبقا نخرج فورا
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> value = new HashSet<int>();

            foreach (int num in nums)
            {
                if (value.Contains(num))
                    return true;

                value.Add(num);
            }
            return false;
        }

        // الاول نشوف الاحتمالات وهيا احتمال ان الكينديدت تبقا اكثر من عنصر لانه بيقول 
        // n\3  
        // فبكدا هحتاج عدادين 
        //229. Majority Element II
            public IList<int> MajorityElement(int[] nums)
            {
                int candidate1 = 0;
                int count1 = 0;
                int candidate2 = 0;
                int count2 = 0;

                foreach (int num in nums)
                {
                    if (candidate1 == num)
                        count1++;

                    else if (candidate2 == num)
                        count2++;
            
                    else if (count1 == 0)
                    {
                        candidate1 = num;
                        count1++;
                    }
                    else if (count2 == 0)
                    {
                        candidate2 = num;
                        count2++;
                    }
                    else
                    {
                        count1 -=1;
                        count2 -=1;
                    }
                }

                count1 =0;
                count2 =0;
             // هنا بنتحقق من العنصر المرشح هل هو فعلا يحقق الشرط ولا لا واذا لم يكن 
             //  فبكدا نضمن انها لن ترجع نتائج غير صحيحه
                foreach (int num in nums)
                {
                    if (candidate1 == num)
                        count1++;
                    else if (candidate2 == num)
                        count2++;
                }

                // هنا اخترت الداتا اسكتراكتشر المناسبة وهيا الليست لانها باتسمحلي بالاضافه بدون حد عكس الارري
                List<int> result = new List<int>();

                if (count1 > nums.Length / 3)
                    result.Add(candidate1);
                if (count2 > nums.Length / 3)
                    result.Add(candidate2);

                return result;
            }



        //  ملحوظه السوال بيقولولنا اننا لازم يبقا فيه عنصر علشان لو مفيش
        //   هندخل في لوب اخري ونشيك المرشح هل بالفعل حقيقي ولا فقط كان اخرلا عنصر بعد الزيرو
        //169. Majority Element
        public int MajorityElement_1(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                    map[nums[i]]++;
                else
                    map[nums[i]] = 1;

                if (map[nums[i]] > nums.Length /2)
                    return nums[i];
            }

            return -1;
        }

        //169. Majority Element
        public int MajorityElement_2(int[] nums)
        {
            int candidate = -1;
            int count = 0;

            foreach (int num in nums)
            {
                if (count == 0)          //  هل الكاونت  بيساوي صفر اذا نعم نضيف المرشح الجديد
                    candidate = num;

                if (candidate == num)    // هل العنصر موجود اذا نعم نزود العداد
                    count++;
                 
                else                     // لا ننقص العداد
                    count--;
            }
            return candidate;          //  نرجع العنضصر المرشح 
        }

        static public void Main()
        {
            //int[] arr = {1,1,1,1,2,2,2,3};
            int[] arr = {1,2};

            Console.WriteLine("Element: " + myMajorityElement2(arr));

            HashSet<int> value = new HashSet<int>();       
        }

    }
}
