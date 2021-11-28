using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int lastDigit = num % 10;

            PrintLastDigitInEnglish(lastDigit);
        }

        static void PrintLastDigitInEnglish(int lastDigit)
        {

            switch (lastDigit)
            {
                case 0:
                {
                    Console.Write("Zero");
                    break;
                }
                case 1:
                {
                    Console.Write("One");
                    break;
                }
                case 2:
                {
                    Console.Write("Two");
                    break;
                }
                case 3:
                {
                    Console.Write("Three");
                    break;
                }
                case 4:
                {
                    Console.Write("Four");
                    break;
                }
                case 5:
                {
                    Console.Write("Five");
                    break;
                }
                case 6:
                {
                    Console.Write("Six");
                    break;
                }
                case 7:
                {
                    Console.Write("Seven");
                    break;
                }
                case 8:
                {
                    Console.Write("Eight");
                    break;
                }
                case 9:
                {
                    Console.Write("Nine");
                    break;
                }
                default:
                    Console.Write("Invalid!");
                    break;
            }
        }
    }
}