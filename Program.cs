using System;

namespace FindFibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            FindFibonacciNumber(317811);
        }

        static void FindFibonacciNumber(int n)
        {
            if(n == 1)
            {
                Console.WriteLine("places 1 and 2");
            }
            if(n == 2)
            {
                Console.WriteLine("place #3");
            }
            if(n == 3)
            {
                Console.WriteLine("place #4");
            }
            int[] fib = new int[n];
            fib[0] = 1;
            fib[1] = 1;
            int i = 1;
            while (fib[i] < n)
            {
                i++;
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            if (fib[i] == n)
            {
                Console.WriteLine("place #" + (i + 1));
            }
            else
                Console.WriteLine("This number is not in the " +
                "fibonacci sequence.");
        }
    }
}
