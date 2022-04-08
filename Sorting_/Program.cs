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

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            
            int swaps = 0;
            int c;
            int count = a.Count;
            for (int j = 0; j < count; j++, count--)
            {
                for (int i = 0; i < count; i++)
                {

                    
                    if (a[i] > a[i + 1])
                    {
                        swaps++;
                        c = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = c;
                    }
                    else
                    {

                    }

                

                }
            }
            if (a[0] > a[1])
            {
                swaps++;
                c = a[0];
                a[0] = a[1];
                a[1] = c;
            }
            Console.WriteLine(swaps);
            Console.Write($"Array is sorted in {swaps} swaps.\nFirst Element: {a.First()}\nLast Element: {a.Last()}");

        }
    }
}
