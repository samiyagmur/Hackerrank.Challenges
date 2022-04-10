using System.Text;
using System;
using System.Collections.Generic;

namespace Breaking.the.Records
{
    class Result
    {

        /*
         * Complete the 'breakingRecords' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY scores as parameter.
         */

        public static List<int> breakingRecords(List<int> scores)
        {
            int countMax = 0;
            int countMin = 0;
            int min = 0;
            int max = 0;

            for (int i = 0; i < scores.Count; i++)
            {
                if (i == 0)
                {
                    min = scores[i];
                    max = scores[i];
                }
                if (scores[i] < min)
                {
                    min = scores[i];
                    countMin++;

                }
                if (scores[i] > max)
                {
                    max = scores[i];
                    countMax++;
                }
            }
            scores.Clear();
            scores.Add(countMin);
            scores.Add(countMax);

            return scores;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = Result.breakingRecords(scores);

            Console.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
