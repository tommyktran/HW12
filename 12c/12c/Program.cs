using System;
using System.Collections.Generic;

namespace _12c
{
    class Program
    {
        static void Main(string[] args)
        {
            Sums(5);
        }
        static void Sums(int sum)
        {
            Sums(sum, sum, new List<int> { });
        }
        static void Sums(int sum, int max, List<int> result)
        {
            if (sum == 0)
            {
                for (int i = 0; i < result.Count - 1; i++)
                {
                    Console.Write(result[i] + " + ");
                }
                Console.Write(result[result.Count - 1]);
                Console.WriteLine();
                return;
            }
            for (int x = Math.Min(sum, max); x > 0; x--)
            {
                int tempsum = sum;
                int tempmax = max;
                var tempresult = new List<int>(result);
                sum -= x;
                max = x;
                result.Add(x);
                Sums(sum, max, result);
                sum = tempsum;
                max = tempmax;
                result = tempresult;
            }
        }
    }
}
