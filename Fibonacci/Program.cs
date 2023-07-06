namespace Fibonacci
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static Dictionary<int, long> fibCache = new Dictionary<int, long>();

        public static void Main(string[] args)
        {
            int n = 50;
            long result = Fibonacci(n);

            Console.WriteLine($"The {n}th Fibonacci number is: {result}");
        }

        public static long Fibonacci(int n)
        {
            if (n <= 2)
                return 1;

            if (fibCache.ContainsKey(n))
                return fibCache[n];

            long fibValue = Fibonacci(n - 1) + Fibonacci(n - 2);
            fibCache[n] = fibValue;

            return fibValue;
        }
    }

}