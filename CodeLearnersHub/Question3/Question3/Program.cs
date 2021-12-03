using System;
using System.Linq;


namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = new[] {1,2,3,3,2};
            
            
            string[] tokens_n = Console.ReadLine().Split('j');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] height_temp = Console.ReadLine().Split(' ');
            height = Array.ConvertAll(height_temp, Int32.Parse);


            var max = height.Max();
            var diff = Math.Max(max - k, 0);
            Console.WriteLine(diff);
        }
    }
}