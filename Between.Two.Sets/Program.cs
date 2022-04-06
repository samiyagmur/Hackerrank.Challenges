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

namespace Between.Two.Sets
{
    internal class Program
    {
        class Result
        {

            /*
             * Complete the 'getTotalX' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER_ARRAY a
             *  2. INTEGER_ARRAY b
             */

            public static int getTotalX(List<int> a, List<int> b)
            {
                int i = a.Max();
                int j = b.Min();
                
                List<int> result = new List<int>();
                List<int> result1 = new List<int>();

                int count = 0;
                int count1 = 0;
                for (; i <=j; i++)
                {

                    for (int k = 0; k < a.Count; k++)
                    {
                        if ((i % a[k]) == 0)
                        {   count++;
                            if (a.Count == count)//2
                            {
                                result.Add(i);
                                count = 0;
                            }
                        }
                    }
                   
                }
                bool durum=b.Count < result

                for (int f = 0; f < b.Count; f++)
                {
                    for (int d = 0; d < result.Count; d++)
                    {
                        if ((b[f] % result[d]) == 0)
                        {
                            count1++;
                            if (b.Count == count1  )
                            {
                                result1.Add(f);
                                count1 = 0;
                            }
                        }
                        
                    }
                    
                    
                }


                return result1.Count;
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int m = Convert.ToInt32(firstMultipleInput[1]);

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

                int total = Result.getTotalX(arr, brr);

                Console.WriteLine(total);

                //textWriter.Flush();
                //textWriter.Close();
            }
        }
    }
}
