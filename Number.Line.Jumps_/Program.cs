﻿using System.CodeDom.Compiler;
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

namespace Number.Line.Jumps
{
    class Result
    {




        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int a = Math.Abs(x1 - x2);
            int b = Math.Abs(v2 - v1);
            int flag = 0;

            if ((x1 >= x2)&&(v1 >= v2))
            {
                return "NO";
            }
            else if ((x2 >= x1) && (v2 >= v1))
            {
                return "NO";
            }
            else
            {
                for (int i = 1; i <= a; i++)
                {
                    double d = (((double)a)/ ((double)b));
                    if (d == i)
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //int x1 = Convert.ToInt32(firstMultipleInput[0]);

            //int v1 = Convert.ToInt32(firstMultipleInput[1]);

            //int x2 = Convert.ToInt32(firstMultipleInput[2]);

            //int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = Result.kangaroo(21, 6, 47, 3);

            Console.WriteLine(result);
            


        }
    }

}
