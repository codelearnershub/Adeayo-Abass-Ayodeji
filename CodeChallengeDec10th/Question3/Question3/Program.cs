using System;
using System.Collections.Generic;
using System.Linq;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = new List<int> {1, 2, 4, 14, 45};
            var num2 = new List<int> {15, 19, 20, 25, 55};
            var outcome = CompareScores(num1, num2);

            Console.WriteLine($"X score: {outcome.ElementAt(0)} Y score: {outcome.ElementAt(1)}");
        }

        public static List<int> CompareScores(List<int> x, List<int> y)
        {
            var ScoreX = 0;
            var ScoreY = 0;
            var i = 0;
            foreach (var item in x)
            {
                if (item > y.ElementAt(i))
                {
                    ScoreX++;
                }

                if (item < y.ElementAt(i))
                {
                    ScoreY++;
                }

                i++;
            }

            return new List<int> {ScoreX, ScoreY};
        }
    }
}