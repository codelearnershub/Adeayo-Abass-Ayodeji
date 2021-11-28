using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0, x = 0;
            Console.Write("enter the digits: ");
            int digits = int.Parse(Console.ReadLine());
            
            ReverseOrder(digits,x,sum);

        }


        static void ReverseOrder(int digits,int x, int reverseSum)
        {
            reverseSum = 0;

            for (int i = digits; i!=0; i=i/10)
            {
                x = i % 10;
                reverseSum = reverseSum * 10 + x;
                
            }
            Console.Write("\nThe reversed order of the digits is " +reverseSum);
        }
    }
}
