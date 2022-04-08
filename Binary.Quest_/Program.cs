using System;
using System.Collections.Generic;
using System.Linq;

namespace Binary.Quest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            var d = DecimalToBinary(n);
            string v = d.Aggregate((x, y) => x + y);


            string[] arr = v.Split('0');
            List<int> lstr = new List<int>();


            foreach (var item in arr)
            {
                lstr.Add(item.Length);
            }

            Console.WriteLine(lstr.Max());

        }
        public static List<string> DecimalToBinary(int n)
        {
            List<string> list = new List<string>();


            for (; n >= 1; n = n / 2)
            {
                if (n % 2 == 1)
                {
                    list.Insert(0, "1");
                }
                else
                {
                    list.Insert(0, "0");
                }

            }
            return list;
        }
    }
}
