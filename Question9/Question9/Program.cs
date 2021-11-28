using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            int descend = 0;
            int j = 0;
            int[] myArray = {5, 2, 1, 6, 7, 8, 3, 4, 5};

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i]+ " ");
            }
            DescendingArray(myArray,descend,j);
        }
        

        static void DescendingArray(int[] myArray, int descend, int j)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                
                for (j = i+1; j < myArray.Length; j++)
                {
                    if (myArray[i]<myArray[j])
                    {
                        descend = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = descend;
                        
                    }
                    Console.WriteLine();
                    
                }
                
            }

            int max = 0;
            for (int k = 0; k < myArray.Length; k++)
            {
                if (myArray[k] > max)
                {
                    max = myArray[k];
                }
                Console.Write(myArray[k]+ " ");
               
            }
            Console.Write("\nThe biggest element of the array is "+ max);
            
           
        }
    }
}