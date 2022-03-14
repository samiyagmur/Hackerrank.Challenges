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

namespace Migratory.Birds
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<int> arr = new List<int>(){1,2,3,4,5,4,3,2,1,3,4};
            int[] count = new int[arr.Max()];
            int max = 0, c = 0;
            
            
            for(int i=0; i<arr.Count; i++)
            {
                count[arr[i]-1]++;
                foreach (var item in count)
                {
                    Console.Write(item+" ");
                }
                
                Console.Write("###");
            }
            
            
            for(int i=0; i<count.Length; i++)
            {
                if(max<count[i]) {max = count[i]; c = i; }
            }
            
            
            Console.Write(c+1);

        }
    }
}
