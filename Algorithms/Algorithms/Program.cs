using Algorithms.Arrays.New_Year_Chaos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Result.minimumBribes(new List<int> { 1, 2, 5, 3, 7, 8, 6, 4 });

            //int t = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine().Trim());

            //    List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            //}
        }

    }
}
//5 = 2
//6 = 0
//7 = 2
//8 = 2

//1 2 3 4 5 6 7 8
//1 2 3 5 4 6 7 8 (5 swap 4)
//1 2 5 3 4 6 7 8 (5 swap 3)
//1 2 5 3 4 7 6 8 (7 swap 6)
//1 2 5 3 7 4 6 8 (7 swap 4)
//1 2 5 3 7 4 8 6 (8 swap 6)
//1 2 5 3 7 8 4 8 (8 swap 6)

//1 2 5 3 7 8 6 4
