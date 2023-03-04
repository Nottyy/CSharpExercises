using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP___LabyrinthEscape___DFS___Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var labyrinth = new string[]
            {
                "     ",
                " @@@ ",
                " @@@ ",
                "  @  ",
                "     ",
            };

            Console.WriteLine(DfsLabyrinthEscape(labyrinth, 0, 0));

            Console.WriteLine(DfsLabyrinthEscapeCount(labyrinth, 0, 0));
        }

        private static int DfsLabyrinthEscapeCount(string[] arr, int row, int col)
        {
            if (row >= arr.Length || col >= arr[row].Length)
            {
                return 0;
            }

            if (row >= arr.Length - 1 && col >= arr[arr.Length - 1].Length - 1)
            {
                Console.WriteLine("Found a way out!");
                return 1;
            }

            if (arr[row][col] == '@')
            {
                return 0;
            }

            return DfsLabyrinthEscapeCount(arr, row, col + 1) + DfsLabyrinthEscapeCount(arr, row + 1, col);
        }

        private static bool DfsLabyrinthEscape(string[] arr, int row, int col)
        {
            if (row >= arr.Length || col >= arr[row].Length)
            {
                return false;
            }

            if (row >= arr.Length - 1 && col >= arr[arr.Length - 1].Length - 1)
            {
                Console.WriteLine("Found a way out!");
                return true;
            }

            if (arr[row][col] == '@')
            {
                return false;
            }

            var right = DfsLabyrinthEscape(arr, row, col + 1);
            var down = DfsLabyrinthEscape(arr, row + 1, col);

            return right || down;
        }
    }
}
