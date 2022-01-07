using System;

namespace Question2_9thJan2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 1, 1, 2, 2, 3};

            int expectedNumbers = nums.Length / nums[0];
            
            RemoveDuplicates(nums, expectedNumbers);
            
        }
        
        
        public static void RemoveDuplicates(int[] arrNumbers, int expNumbers)
        {
            int counter = 0;
            
            

            for (int i = 0; i < expNumbers; i++)
            {
                if (i < expNumbers - 2 &&
                    (arrNumbers[i] == arrNumbers[i + 1] && (arrNumbers[i] == arrNumbers[i + 2])))
                {
                    continue;
                }
                else
                {
                    arrNumbers[counter] = arrNumbers[i];
                    counter++;
                }
                          

            }
            Console.Write($"Output: { counter}, nums = ");
            
            for (int j = 0; j< counter; j++)
            {
                Console.Write(arrNumbers[j]);
                if (j!=counter-1)
                {
                    Console.Write(",");
                }
            }
            
            
        }
    }
}