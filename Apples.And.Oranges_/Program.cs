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


namespace Apples.And.Oranges
{
    internal class Program
    {
        class Result
        {
            // houseStartPuint=s;
            // houseEndPoint=t;
            // 7 11
            //5 15
            //3 2
            //-2 2 1
            //5 -6
            // applesTreePoint=a;
            // orangesTreePoint=b;
            // distanceApple=d.x1;
            // apples=m;
            // oranges=n;
            /*
             * Complete the 'countApplesAndOranges' function below.
             *
             * The function accepts following parameters:
             *  1. INTEGER s
             *  2. INTEGER t
             *  3. INTEGER a
             *  4. INTEGER b
             *  5. INTEGER_ARRAY apples
             *  6. INTEGER_ARRAY oranges
             */

            public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
            {
                int appleCountOnHouse = 0;
                int orangeCountOnHouse = 0;

                for (int i = 0; i < apples.Count; i++)
                {
                   apples[i]+=a;

                    if(s<=apples[i] && apples[i]<=t)
                    {
                        appleCountOnHouse++;

                    }
                }

                for (int i = 0; i < oranges.Count; i++)
                {
                    oranges[i] +=a;

                    if (s <= oranges[i] && oranges[i] <= t)
                    {
                        orangeCountOnHouse++;
                    }
                }
                Console.WriteLine(appleCountOnHouse+"\n"+orangeCountOnHouse);

            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int s = Convert.ToInt32(firstMultipleInput[0]);

                int t = Convert.ToInt32(firstMultipleInput[1]);

                string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int a = Convert.ToInt32(secondMultipleInput[0]);

                int b = Convert.ToInt32(secondMultipleInput[1]);

                string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int m = Convert.ToInt32(thirdMultipleInput[0]);

                int n = Convert.ToInt32(thirdMultipleInput[1]);

                List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

                List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

                Result.countApplesAndOranges(s, t, a, b, apples, oranges);
            }
        }
    }
}
