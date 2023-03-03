using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP___FindMinNumberRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 4, 9, -2, 0, 22, 111, 3, 5 };
            Console.WriteLine(FindMinNum(arr, arr.Length));
        }

        private static int FindMinNum(int[] arr, int length)
        {
            if (length == 1)
            {
                return arr[0];
            }

            var minTillNow = FindMinNum(arr, length - 1);

            return minTillNow < arr[length - 1] ? minTillNow : arr[length - 1];
        }
    }
}
