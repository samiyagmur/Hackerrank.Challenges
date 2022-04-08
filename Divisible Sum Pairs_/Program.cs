using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Divisible_Sum_Pairs
{
    class Result
    {

        /*
         * Complete the 'divisibleSumPairs' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER k
         *  3. INTEGER_ARRAY ar
         */

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int sum = 0;
            int sumCount = 0;
            int j = 1;
            //6
            for (int i = 0; i < n; i++)
            {
                j = i + j;
                //Console.WriteLine(i);
                for (; j < n; j++)
                {
                    sum = ar[i] + ar[j];//j=1 oluyor döndükten sonra
                    //Console.WriteLine(i);
                    if (sum % k == 0)
                    {
                        sumCount++;
                    }
                    sum = 0;
                }
                j = 1;
    

            }
            return sumCount;







        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.divisibleSumPairs(n, k, ar);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
