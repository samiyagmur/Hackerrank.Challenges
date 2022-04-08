using System;
using System.Linq;

namespace Scope
{
    using System;
    using System.Linq;

    class Difference
    {
        private int[] elements;
        private int maximumDifference;

        public int[] Elements { get => elements; set => elements = value; }
        public int MaximumDifference { get => maximumDifference; set => maximumDifference = value; }

        public  Difference(int[] arr)
        {
            Elements = arr;
            //10
 
        }

        public void computeDifference()
        {
            int count =Elements.Length;
            
            MaximumDifference = Math.Abs(Elements[count - 1] - elements[count - 2]);



        }

    }
        // End of Difference Class

    class Solution
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.MaximumDifference);
        }
    }
    
}