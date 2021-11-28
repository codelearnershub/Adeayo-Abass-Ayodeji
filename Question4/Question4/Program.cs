using System;
using System.Collections.Generic;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] counters = new int[size];

            for (int i = 0; i < counters.Length; i++)
            {
                Console.Write($"enter number {i + 1}: ");
                counters[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("enter the occurence number to be checked: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write($"The occurence of {num} is {NumOccurrence(counters, num)}");
        }
        
        static int NumOccurrence(int [] counters, int occur)
        {
            int count = 0;
            foreach (var item in counters)
            {
                if (occur == item)
                {
                    count++;
                }
            }
            return count;

        } 
    }
}


        