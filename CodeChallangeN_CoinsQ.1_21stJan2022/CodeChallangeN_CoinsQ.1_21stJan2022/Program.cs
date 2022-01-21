using System;
using System.Linq;

namespace CodeChallangeN_CoinsQ._1_21stJan2022
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int []coins = {4, 3, 1};
            int arrayLength = coins.Length;
            int x = 8;
            Console.Write("Output: "+
                          MinCoins(coins, arrayLength, x));
        }
        
        static int MinCoins(int []coins, int coinsLength, int x)
        {

            if (x == 0) return 0;
            int assumedResult = 0;
            if (coins.Max() > assumedResult)
            {
                assumedResult = coins.Max();
            }
         
            
            for (int i = 0; i < coinsLength; i++)
            {
                if (coins[i] <= x)
                {
                    int altResult = MinCoins(coins, coinsLength, x-coins[i]);
                    
                    if (altResult != coins.Max() &&
                        altResult + 1 < assumedResult)
                        assumedResult = altResult + 1;
                }
            }
            return assumedResult;
        }

    }
}