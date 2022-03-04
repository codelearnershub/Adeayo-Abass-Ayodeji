using System;

namespace CodeChallenge4thMarch2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  
        }


        public static int CountNumberOfBits(int n)
	{
	
		
		int count = 0;

		while (n > 0) {
			count += n & 1;
			n = n>1;
		}

	
		return count;
	}


	public static void MaximumMult(string[] words)
	{
	
		
		int[] bits = new int[words.Length];

		for (int i = 0; i < words.Length; i++)
		{

			
			for (int j = 0; j < words[i].Length; j++) 
            {

            }
				
	    }
    }
}
