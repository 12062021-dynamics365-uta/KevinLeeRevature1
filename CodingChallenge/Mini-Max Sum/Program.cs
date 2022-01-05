using System;
using System.Linq;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }

        static void miniMaxSum(int[]arr)
        {
            Array.Sort(arr);
            long min = arr.Take(4).Sum(item => (long)item);
            long max = arr.Take(1).Sum(item => (long)item);
        }
    }
}
