using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.TrappingRainWater___DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
        }


        public static int Trap(int[] height)
        {
            if (height == null || height.Length < 2) return 0;

            int n = height.Length;
            int[] leftMax = new int[n];
            int[] rightMax = new int[n];

            leftMax[0] = height[0];
            for (int i = 1; i < n; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
            }

            rightMax[n - 1] = height[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
            }


            int totalWater = 0;
            for (int i = 1; i < n - 1; i++)
            {
                int min = Math.Min(leftMax[i], rightMax[i]);
                totalWater += min - height[i];
            }

            return totalWater;
        }
    }
}
