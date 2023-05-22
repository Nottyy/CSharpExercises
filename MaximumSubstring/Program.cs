using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = "zmieztxwjl";
            Console.WriteLine(maxSubstring(str));
            int s = 2;
            double p = 4.1;
            Console.WriteLine(s + p);
        }

        public static string maxSubstring(string s)
        {
            var max = -1;
            var result = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= max)
                {
                    max = s[i];
                    var cur = s.Substring(i);

                    if (cur.CompareTo(result.ToString()) > 0)
                    {
                        result.Clear();
                        result.Append(s.Substring(i));
                    }
                }
            }

            return result.ToString();
        }
    }
}
