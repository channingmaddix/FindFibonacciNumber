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
            if(n == 1)                                     //Kind of cheating, these first three if statements check if 
            {                                              //'n' is in one of the first 3 places of the sequence and writes
                Console.WriteLine("places 1 and 2");       //the place of the number.
            }
            if(n == 2)
            {
                Console.WriteLine("place #3");
            }
            if(n == 3)
            {
                Console.WriteLine("place #4");
            }
            int[] fib = new int[n];                         //Because we don't know how long the array needs to be for any
            fib[0] = 1;                                     //given number 'n' until we write it out, the array is intialized
            fib[1] = 1;                                     //with a length of 'n', to be safe.
            int i = 1;
            while (fib[i] < n)                              //This while loop creates the fibonacci sequence. 'i' both helps with
            {                                               //the creation of the array and counting the number of places 'n' is at.
                i++;
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            if (fib[i] == n)                                //if statement to ensure fib[i] equals 'n', and didn't exceed it.
            {
                Console.WriteLine("place #" + (i + 1));
            }
            else
                Console.WriteLine("This number is not in the " +
                "fibonacci sequence.");
        }
    }
}
