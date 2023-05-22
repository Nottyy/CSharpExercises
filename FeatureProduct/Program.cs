using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static void Main(string[] args)
        {
            List<String> st = new List<string>();
            st.Add("red");
            st.Add("red");
            st.Add("bl");
            st.Add("bl");
            st.Add("redd");
            st.Add("abc");

            Console.WriteLine(featuredProduct(st));
        }

        public static string featuredProduct(List<string> products)
        {
            var dict = new Dictionary<string, int>();

            for (int i = 0; i < products.Count; i++)
            {
                if (dict.ContainsKey(products[i]))
                {
                    dict[products[i]]++;
                }
                else
                {
                    dict.Add(products[i], 1);
                }
            }

            var sorted = dict.OrderByDescending(x => x.Value);

            return sorted.First().Key;
        }
    }
}
