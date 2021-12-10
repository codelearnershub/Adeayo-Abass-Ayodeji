using System;
using System.Collections.Generic;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {7, 1, 3, 4, 1, 7};
            Console.WriteLine(MinimunDistance(num));
        }

        public static int MinimunDistance(int[] a)
        {
            Dictionary<int, int> pairStrorage = new Dictionary<int, int>();
            int minDistance = Int32.MaxValue;
            int previousIndex, currentIndex = 0;
            
            for (int i = 0; i < a.Length; i++)
            {
                if (pairStrorage.ContainsKey(a[i]))
                {
                    currentIndex = i;
                    previousIndex = pairStrorage[a[i]];
                    minDistance = Math.Min((currentIndex - previousIndex), minDistance);
                }

                if (!pairStrorage.ContainsKey(a[i]))
                {
                    pairStrorage.Add(a[i], i);
                }
                else
                {
                    pairStrorage[a[i]] = i;
                }
            }

            return (minDistance == Int32.MaxValue? -1 : minDistance);
        }
    }
}