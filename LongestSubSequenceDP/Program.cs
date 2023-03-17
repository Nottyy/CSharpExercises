using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubSequenceDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new int[] { 5,7,3 };
            var p = new int[] { 7, 3 };
            var result = DP(s, p);
            Console.WriteLine(result);
        }

        private static int DP(int[] s, int[] p)
        {
            // 54126
            // 748192

            var dp = new int[s.Length + 1, p.Length + 1];

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= p.Length; j++)
                {
                    if (s[i - 1] == p[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    Console.Write(dp[i, j] + " ");
                }
                Console.WriteLine();
            }

            return dp[s.Length, p.Length];
        }
    }
}


