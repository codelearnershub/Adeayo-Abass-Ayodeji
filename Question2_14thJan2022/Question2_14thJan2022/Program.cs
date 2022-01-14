using System;

namespace Question3_14thJan2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(IsValid(input));
           
        }
        
        public static bool IsValid(string input)
        {
            int count = 0;
            if (input.Length%2 == 0) return true;
            

            if (input.Length % 2 != 0) return false;
                


            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == ')' || input[i] == '*')
                {
                    if (count == 0)
                        return false;
                    count--;
                }
                else
                    count++;
            }

            return false;
        }
    }
}