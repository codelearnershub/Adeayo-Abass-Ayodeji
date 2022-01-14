using System;

namespace Question1_14thJan2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = {2, 10};

            Console.WriteLine($"Input: [{string.Join(',' ,Arr)}]");
           PrintTheLargestNum(Arr);
        }


        public static void PrintTheLargestNum(int[] arrNumbers)
        {
            int max = 0;
            int IndexOfNum_WithMaxLeftMostDigit = 0;

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                int num = arrNumbers[i];

                do
                {
                    int rem = num % 10;
                    num = num / 10;

                    if (num == 0)
                    {
                        if (max < rem)
                        {
                            max = rem;
                            IndexOfNum_WithMaxLeftMostDigit = i;
                        }
                    }

                } while (num > 0);

            }
            Console.Write("Output: "  );
            for (int x = IndexOfNum_WithMaxLeftMostDigit; x < arrNumbers.Length; x++)
            {
                Console.Write(arrNumbers[x]);
            }

            for (int y = 0; y < IndexOfNum_WithMaxLeftMostDigit; y++)
            {
                Console.Write(arrNumbers[y]);
            }
        }
    }
    
}
