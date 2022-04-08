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



namespace Subarray_Division
{
    class Result
    {

        /*
         * Complete the 'birthday' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY s
         *  2. INTEGER d
         *  3. INTEGER m
         */
        //5
        //1 2 1 3 2
        //3 2

        public static int birthday(List<int> s, int d, int m)
        {
            int sum = 0;
            int sumCount=0;
               
            for (int j = 0; j <= s.Count-m; j++)
            {
                for (int i = 0; i+j < m+j; i++)
                {
                    sum = s[i + j] + sum;
                }
                if (d == sum)
                {
                    sumCount++;
                }
                sum = 0;
            }
            return sumCount;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = Result.birthday(s, d, m);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
