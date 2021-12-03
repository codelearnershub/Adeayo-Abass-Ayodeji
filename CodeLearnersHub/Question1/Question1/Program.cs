using System;
using System.Linq;


namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = new long [5]{3,9,5,7,1};
            
            minMaxSum(arr);
        }

        static void minMaxSum(long[] numbers)
        {
            long sumMax = 0;
            long sumMin = 0;
            
            Array.Sort(numbers);
            sumMax += numbers[1] + numbers[2] + numbers[3] + numbers[4];
            sumMin += numbers[0]+numbers[1]+numbers[2]+numbers[3];
            Console.Write($"The min values of the positive arrays are min {sumMin}, max {sumMax}");
        }
    }
}