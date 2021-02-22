using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Add(7, 14, 5));
        }
        static class Math
        {
            public static int Add2numbers(int a, int b)
            {
                return a + b;
            }
            public static int Add(int a, int b, int c)
            {
                return a + b + c;
            }
        }
    }
}
