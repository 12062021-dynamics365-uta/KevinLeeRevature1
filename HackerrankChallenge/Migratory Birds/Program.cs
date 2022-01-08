using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Migratory_Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.MigratoryBirds(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

    class Result
    {

        /*
         * Complete the 'migratoryBirds' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static int migratoryBirds(List<int> arr)
        {
            int[] numBirdSightings = new int[6];

            foreach (int birdId in arr)
            {
                numBirdSightings[birdId]++;
            }

            int maxSightings = 0;
            int idOfMaxSightings = 0;

            for (int r = 1; r < 6; r++)
            {
                if (numBirdSightings[r] > maxSightings)
                {
                    maxSightings = numBirdSightings[r];
                    idOfMaxSightings = r;
                }
            }

            return idOfMaxSightings;

        }

        internal static int MigratoryBirds(List<int> arr)
        {
            throw new NotImplementedException();
        }
    }
}
