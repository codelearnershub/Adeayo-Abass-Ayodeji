﻿using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Number ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter your Second Number ");
            string number2 = Console.ReadLine();

            if(number1.Length >= number2.Length )
            {
                int [] numbers1 = new int [number1.Length];
                int [] numbers2 = new int [number1.Length];

                
                for(int i = 0; i < number1.Length; i++)
                {
                    char y  =  number1[number1.Length - (1 + i)];
                    numbers1[i] = (int)y;
                }
                for(int i = 0; i < number2.Length; i++)
                {
                    char y  =  number2[number2.Length - (1 + i)];
                    numbers2[i] = (int)y;
                }

                string x = SumTwoLongPositiveInteger(numbers1 , numbers2);

                Console.Write("The additon of the numbers gives ");
                for(int i = 0; i < x.Length; i++)
                {
                    Console.Write($"  {x[x.Length - (1 + i)]} ");
                }
            }
            else
            {
                int [] numbers1 = new int [number2.Length];
                int [] numbers2 = new int [number2.Length];
                for(int i = 0; i < number1.Length; i++)
                {
                    char y  =  number1[number1.Length - (1 + i)];
                    numbers1[i] = (int)y;
                }
                for(int i = 0; i < number2.Length; i++)
                {
                    char y  =  number2[number2.Length - (1 + i)];
                    numbers2[i] = (int)y;
                }

                string x = SumTwoLongPositiveInteger(numbers1 , numbers2);

                Console.Write("The additon of the numbers gives ");
                for(int i = 0; i < x.Length; i++)
                {
                    Console.Write($"  {x[x.Length - (1 + i)]} ");
                }

            }

            

            

            
        }
        static string SumTwoLongPositiveInteger(int [] number1 , int [] number2 )
        {
            string a = " ";

            int mod = 0;
            int sum = 0;
            int div = 0;
            
            for(int y = 0; y < number1.Length; y++)
            {
                if(y == 0)
                {
                    sum = number1[y] + number2[y];
                    if(sum >= 10)
                    {
                        mod = sum%10;
                        div = sum/10;
                        a += $" {mod}";
                    }
                    else 
                    {
                        a += $" {sum}";
                    }
                }
            }
            
            return a;
            
        }    
        

    }
}
