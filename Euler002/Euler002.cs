/* Even Fibonacci numbers
 * Problem 2
 * https://projecteuler.net/problem=2
 */

using System;

namespace Euler002
{
    class Euler002
    {
        static int Fibonacci(int number) // Returns the nth Fibonacci number where n = number
        {
            switch (number)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
                default:
                    return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
        }

        static void Main(string[] args)
        {
            int max = 4000000;
            int answer = 0;

            for (int i = 1, fibNumber = 1; fibNumber < max; i++, fibNumber = Fibonacci(i)) // Loops through all Fibonacci numbers below 'max'
            {
                if (fibNumber % 2 == 0)
                {
                    answer += fibNumber;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
