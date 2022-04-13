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

        

        public static int sockMerchant(int n, List<int> ar)
        {
            List<int> listOfDistinct = ar.Distinct().ToList();//10 20 30 50
            List<int> temporaryList = new List<int>();//first loop=10 10 10 10,SecondLoop=20 20 20,Third loop= 30,Forty loop= 50
            List<int> conditionList = new List<int>();//4 3 1 1
            int count = 0;
            

            for (int i = 0; i < listOfDistinct.Count; i++)
            {
                temporaryList = ar.FindAll(x => x == listOfDistinct[i]);//We are find same value and set to list all.For Exammple:List:10 10 10 10
                conditionList.Add(temporaryList.Count);//We are add tempList count other list. 
                temporaryList.Clear();//We are clear temporary list for next loop.
            }


            for (int i = 0; i < conditionList.Count; i++)
            {

                if (conditionList[i] != 1)
                {
                    if (conditionList[i] % 2 == 0)
                    {
                        count += (conditionList[i] / 2);//We are Divide 2 becouse of pair socks.We are counting pair socks.
                    }
                    else
                    {
                        count += ((conditionList[i] - 1) / 2);
                    }

                }
                else
                {
                }
            }
            return count;//At last we return count.

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.sockMerchant(n, ar);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
