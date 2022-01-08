using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sales_by_Match
{
    class Program
    {
        public static object Result { get; private set; }

        static void Main(string[] args)
        {
            System.IO.TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        public static int sockMerchant(int n, List<int> ar)
        {
            int pair = 0;
            int max = ar.Max() + 1;
            for (int i = 0; i < n; i++)
            {
                if (ar[i] == max)
                    continue;                

                    for (int j = i + 1; j < n; j++)
                    {
                        ar[i] = max;
                        ar[j] = max;
                        pair++;
                        break;
                    }
                }
                return pair;
            }
        }
    }


