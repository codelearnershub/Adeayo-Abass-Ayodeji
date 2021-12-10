using System;

namespace Question1
{
    class Program
    {

        static int DigitCount(int n)
        {
            int number = n, count = 0;
            while (number !=0)
            {
               int d = number % 10;
                number /= 10;

                if (d>0 && n%d==0)
                {
                    count++;
                }
            }

            return count;
        }
        
        
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write(DigitCount(num));
        }
    }
}