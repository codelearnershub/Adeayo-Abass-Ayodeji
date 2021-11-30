using System;
using System.Diagnostics.CodeAnalysis;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = {10,12,4,5,7,8,9,12,9,3};
            
            Console.Write("Task Menu: Press '1' to put digits into reversed order; '2' to Calculate average of " +
                          "given sequence; and '3' to compute a linear equation: ");

            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                {
                    int sum=0, x = 0;
                    Console.Write("enter the digits: ");
                    int digits = int.Parse(Console.ReadLine());
                    
                    ReverseOrder(digits,x,sum);
                    break;
                }

                case 2:
                {
                    int sum = 0;
                    int average = 0;
                    Average(average, sum, numbers);
                    break;
                }
                case 3:
                {
                    int x = 0;
                    
                    Console.Write("Note: The coefficient a must be non-zero, and integer number " +
                                  "must be a positive in the range 1…50,000,000");
                    Console.Write("enter the value of a: ");
                    decimal a = decimal.Parse(Console.ReadLine());
                    
                    Console.Write("enter the value of b: ");
                    decimal b = decimal.Parse(Console.ReadLine());

                    LinearEquation(a,b,x);
                    break;
                }
                default:
                {
                    Console.Write("Invalid selection!");
                    break;
                }
            }
            
            
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
        
        static double Average(int average, int sum, int [] numbers)
        {
            foreach (var item in numbers)
            {
                sum += item;
                average = sum /numbers.Length;
            }
            
            Console.Write("The average of the sequence is" +average);
            return average;
        }

        static decimal LinearEquation(decimal a, decimal b, decimal x)
        {
            if (a==0)
            {
                b =0;
            }
            else if(a!=0)
            { 
                decimal linear=(a * x) + b;
                x = (-b / a);
            }
           
            Console.Write("The linear equation is " +x);
            return x;
        }
        
        
    }
    }

