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

namespace _2D.Arrays                
{
    class Solution
    {
        public static void Main(string[] args)
        {

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            List<int> arr1 = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {


                   int toplam = arr[i][j]      +   arr[i][j + 1]   +      arr[i][j + 2]
                                           
                                               + arr[i + 1][j + 1] +

                              arr[i + 2][j]    + arr[i + 2][j + 1] +    arr[i + 2][j + 2];

                    arr1.Add(toplam);

                }
            }
            
        }
    }
}
//2 4 4 0 0 0
//0 2 0 0 0 0
//1 2 4 0 0 0
//0 0 1 1 1 0
//0 0 0 1 0 0
//0 0 1 1 1 0

//arr[i][j]  + arr[i][j+1]  + arr[i][j+2]
//           + arr[i+1][j+1]+
//arr[i+2][j]+ arr[i+2][j+1]+ arr[i+2][j+2]
//                          + arr[i+3][j+2] +arr[i+3][j+3]+ arr[i+3][j+4]   
//                                          +arr[i+4][j+3]
//                          +arr[i+5][j+2]  +arr[i+5][j+3]+ arr[i+5][j+];
//
//
