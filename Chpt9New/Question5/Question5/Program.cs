using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighbors = {7, 8, 10, 3, 2, 4, 20,18,12};
            
            Console.Write("Check if a number of a certain position is greater than its two neighbors:");
            
            Console.Write("\nenter the index(btw 0 to 8) to compare: ");
            int numberToCompare = int.Parse(Console.ReadLine());
            
            bool check= CheckNumbers(neighbors,numberToCompare);
            Console.Write("The number checked is "+check);
        }



        static bool CheckNumbers(int[] neighbors, int num)
        {
            bool check = true;

            if (neighbors[num]>neighbors[num-1] && neighbors[num]>neighbors[num+1])
            {
                check = true;
            }
            else
            {
                check = false;
            }

            return check;
        }
    }
}