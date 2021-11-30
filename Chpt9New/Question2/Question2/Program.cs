using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());
            
            int x = GetMax(GetMax(a, b), c);

            Console.Write($"The max of {a},{b},{c} is {x}");
        }


        static int GetMax(int a, int b)
        {
            int max = 0;
            if (a>b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            return max;
        }           

        


    }
    
}