using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DP___Fibonacci___Recursive_and_Iterative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 30;
            Console.WriteLine($"Fibonacci Recursive: ({n}) -> " + FibonacciRecursive(n));

            var memo = new BigInteger[1000000];
            n = 1500;
            Console.WriteLine($"Fibonacci Recursive with Memo: ({n}) -> " + FibonacciRecursiveMemo(n, memo));

            n = 10;
            Console.WriteLine($"Fibonacci Iterative: ({n}) -> " + FibonacciIterative(n));

        }

        private static BigInteger FibonacciRecursive(int n)
        {
            if (n < 2)
            {
                return 1;
            }

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        private static BigInteger FibonacciRecursiveMemo(int n, BigInteger[] memo)
        {
            if (n < 2)
            {
                return 1;
            }

            if (memo[n] == 0)
            {
                memo[n] = FibonacciRecursiveMemo(n - 1, memo) + FibonacciRecursiveMemo(n - 2, memo);
            }

            return memo[n];
        }

        private static BigInteger FibonacciIterative(int n)
        {
            BigInteger firstNum = 1;
            BigInteger secondNum = 1;

            for (int i = 2; i <= n; i++)
            {
                var currentNumber = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = currentNumber;
            }

            return secondNum;
        }
    }
}
