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

namespace Sales.by.Match
{
    class Result
    {

        /*
         * Complete the 'sockMerchant' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY ar
         */

        public static int sockMerchant(int n, List<int> ar)
        {
            ar.Sort();//10 20 20 10 10 30 50 10 20
            int equlty = 0;
            int pairSockOnlyEven = 0;
            int pairSockOnlyOdd = 0;
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int getListValueSequentially = ar[i];//10 10 10 10 20 20 20 30 50
                int getCountEveryValueOnList = (int)ar.LongCount(x => x == getListValueSequentially);//4 3 1 1
                list.Add(getCountEveryValueOnList);// 4 3 1 1
                list = list.Distinct().ToList();// 4 3 1
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != 1)//1
                {
                    if (list[i] % 2 == 0)//4
                    {
                        pairSockOnlyEven = list[i] / 2;//we search how many pair in 4
                    }
                    else if (list[i] % 2 == 1)//3
                    {
                        list[i] -= 1;//3-1=2
                        pairSockOnlyOdd = list[i] / 2;//we search how many pair in 2
                        
                    }
                }
            }

            return (pairSockOnlyEven + pairSockOnlyOdd);

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
