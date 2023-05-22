using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = "aabcccc";
            Console.WriteLine(compressedString(str));
        }

        public static string compressedString(string message)
        {
            var sb = new StringBuilder();
            var counter = 1;
            char curChar = message[0];

            for (int i = 1; i < message.Length; i++)
            {
                if (message[i] == curChar)
                {
                    counter++;
                    
                }
                else
                {
                    if (counter != 1)
                    {
                        sb.Append(curChar.ToString() + counter);
                    }
                    else
                    {
                        sb.Append(curChar);
                    }
                    curChar = message[i];
                    counter = 1;
                }
            }

            if (counter != 1)
            {
                sb.Append(curChar.ToString() + counter);
            }
            else
            {
                sb.Append(curChar);
            }

            return sb.ToString();
        }
    }
}
