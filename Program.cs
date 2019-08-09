using System;

namespace FindFibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            FindFibonacciNumber(317811);
        }

        static void FindFibonacciNumber(long n)             //This method creates an array and counts the the numbers of the array 
        {                                                  //up until 'n'.
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
            long[] fib = new int[n];                         //Because we don't know how long the array needs to be for any
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
        
        static void FindFibonacciNumber2(long n)         //UPDATE: I created this other method to calculate the place of 'n'
        {                                               //because the array in the first method used too much memory. 
            if (n == 1)
            {
                Console.WriteLine("places 1 and 2");
            }
            else
            {
                int count = 2;
                long i = 1;
                long j = 1;

                while (i < n && j < n)                      //Uses two variables and increments their values by each other, 
                {                                           //counting each time.
                    i += j;
                    j += i;
                    count = count + 2;
                }
                if (j == n)
                {
                    Console.WriteLine("place #" + (count));
                }
                else if (i == n)
                {
                    Console.WriteLine("place #" + (count - 1));
                }
                else
                    Console.WriteLine("# not in Fibonacci sequence.");
            }
        }
    }
}
