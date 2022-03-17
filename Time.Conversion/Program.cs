using System;
using System.Collections.Generic;
using System.IO;
 

namespace Time.Conversion
{
    class Result
    {

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string timeConversion(string s)
        {
            string hour = s.Substring(0, 2); //07:05:45PM
            int lastHour = Convert.ToInt32(hour);
            string pm = s.Substring(8, 2);
            string rmv = s.Remove(0, 2);
            string rmv1 = rmv.Remove(6, 2);

            if (pm == "PM" && hour!="12")
            {
                lastHour += 12;

                return rmv1.Insert(0, lastHour.ToString());
            }
            else if (hour == "12" && pm == "PM")
            {

                return rmv1;
            }
            else if (hour == "12" && pm == "AM")
            {

                return rmv1.Insert(0, "00");
            }

            return rmv1;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            

            string s = Console.ReadLine();
            
            string result = Result.timeConversion(s);

            Console.WriteLine(result);
            


        }
    }
}
