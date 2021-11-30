using System;

namespace Question13
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("enter the value of coefficient X^0: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("enter the value of coefficient X^1: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.Write("enter the value of coefficient X^2: ");
                int num3 = int.Parse(Console.ReadLine());

                int[] numbers1 = {num3, num2, num1};
                int[] numbers2 = {-1, num2};

                int mult1 = 0;
                int mult2 = 0;
                int x = 0;

                for (int i = 0; i < numbers2.Length; i++)
                {
                    if (i == 0)
                    {
                        mult1 = numbers2[x] * numbers1[x];
                    }
                    else
                    {
                        mult2 = numbers1[1] * numbers2[1];
                    }

                    x++;
                }

                Polynomials(numbers1, numbers2, mult1, mult2, num1, num2, num3);

            

            static void Polynomials(int[] numbers1, int[] numbers2, int sum1, int sum2, int num1, int num2, int num3)
            {

                if (sum2 < 0 && sum1 < 0)
                {
                    Console.Write(
                        $"The sum of polynomials ({num3}x^2 + {num2}x -{num1}) + ({num2}x -{num1} = {num3}x^2 {sum2}x {sum1}");
                }

                if (sum2 < 0 && sum1 > 0)
                {
                    Console.Write($"The sum of polynomials ({num3}x^2 + {num2}x -{num1}) + ({num2}x -{num1} = " +
                                  $"{num3}x^2 {sum2}x + {sum1}");
                }

                if (sum2 > 0 && sum1 < 0)
                {
                    Console.Write($"The sum of polynomials ({num3}x^2 + {num2}x -{num1}) + ({num2}x -{num1} = " +
                                  $"{num3}x^2 + {sum2}x {sum1}");
                }

                if (sum2 > 0 && sum1 > 0)
                {
                    Console.Write($"The sum of polynomials ({num3}x^2 + {num2}x -{num1}) + ({num2}x -{num1}) = " +
                                  $"{num3}x^2 + {sum2}x + {sum1}");
                }
                else
                {
                    Console.Write("\nZero");
                }

            }
        }
    }
}