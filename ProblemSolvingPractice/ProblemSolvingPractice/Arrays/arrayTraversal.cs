using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Arrays
{
    public class arrayTraversal
    {
             /// Eazyyyyyyyyyyyyyyyyyy hhh🤷       Day 1        7 easy Problem From ChatGPT 
       

        static int FindMax(int[] arr)
        {
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= max)
                    max = arr[i];
            }
            return max;
        }

     
        static int FindMin(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= max)
                    max = arr[i];
            }
            return max;
        }

        static int SumElements(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum+=arr[i];
            }
            return sum;
        }

        static bool isExists(int[] arr, int N)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (N == arr[i])
                    return true;
            }

            return false;
        }

        static int NumOverThen10(int[] arr)
        {
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 10)
                    result++;             
            }

            return result; 
        }

        static bool IsPositive(int[] arr)
        {
            for (int i = 0; i< arr.Length; i++)
            {
                if (arr[i] < 0)
                    return false;
            }
            return true;
        }


    }
}
