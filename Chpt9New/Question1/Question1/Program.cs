using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            
            Greetings(name);
        }



        static void Greetings(string name)
        {
            Console.Write("Hello, " +name +"!");
        }
    }
}