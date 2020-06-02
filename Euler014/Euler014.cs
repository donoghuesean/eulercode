/* Longest Collatz sequence
 * Problem 14
 * https://projecteuler.net/problem=14
 */

using System;
using System.Collections.Generic;

namespace Euler014
{
    class Euler014
    {
        static Dictionary<long, int> collatzDict = new Dictionary<long, int>(); // Caches Collatz chain length of known starting numbers

        static int CollatzLength(int startingNumber) // Returns Collatz chain length of startingNumber as int
        {
            if (collatzDict.ContainsKey(startingNumber))
            {
                return collatzDict[startingNumber];
            }
            else
            {
                int chainLength = 1;
                long number = startingNumber;

                while (number != 1)
                {
                    if (number % 2 == 0) // Rule 1: n -> n / 2 (n is even)
                    {
                        number /= 2;
                    }
                    else // Rule 2: n -> 3n + 1 (n is odd)
                    {
                        number = (number * 3) + 1;
                    }
                 
                    if (collatzDict.ContainsKey(number)) // Check for known numbers
                    {
                        chainLength += collatzDict[number];
                        break; // No need to keep looping after landing on a known number
                    }
                    else
                    {
                        chainLength++;
                    }
                }
                collatzDict.Add(startingNumber, chainLength);
                return chainLength;
            }
        }

        static void Main(string[] args)
        {
            int longestStartingNumber = 1;
            int currentCollatz;

            for (int i = 1; i <= 1000000; i++)
            {
                currentCollatz = CollatzLength(i);
                if (currentCollatz > collatzDict[longestStartingNumber])
                {
                    longestStartingNumber = i;
                }
            }

            Console.WriteLine(longestStartingNumber);
        }
    }
}
