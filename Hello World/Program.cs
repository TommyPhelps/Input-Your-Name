using System;

namespace Hello_World
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello World Program";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Hello what is your name?");
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}