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


namespace Bill.Division
{
    class Result
    {

        /*
         * Complete the 'bonAppetit' function below.
         *
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY bill
         *  2. INTEGER k
         *  3. INTEGER b
         */

        public static void bonAppetit(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);
            int cost = 0;
            
            int brainPayment;
            for (int i = 0; i < bill.Count; i++)
            {
                cost += bill[i];

            }
            brainPayment = (cost / 2);

            if (brainPayment == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                brainPayment = b - brainPayment;
                Console.WriteLine(brainPayment);
            }

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            Result.bonAppetit(bill, k, b);
        }
    }

}
