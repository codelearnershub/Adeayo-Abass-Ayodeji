using System;
using System.Numerics;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter n!(range 1-100): ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            
            BigInteger nFacto = 1;
            NFactorial(nFacto,n);

        }


        static BigInteger NFactorial(BigInteger nFacto, BigInteger n)
        {
          
            do
            {
                nFacto *= n;
                n--;
                
            } while (n>0);
            Console.Write($"n!= {nFacto}");

            return nFacto;
        }
    }
}