/* Summation of primes
 * Problem 10
 * https://projecteuler.net/problem=10
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler010
{
    class Euler010
    {
        static void SieveOfEratosthenes(List<int> numberList)
        {
            int listIndex = 0;
            int currentSquare = 0;
            int currentNumber;
            while (currentSquare < numberList.Last())
            {
                currentNumber = numberList[listIndex];
                currentSquare = currentNumber * currentNumber;
                numberList.RemoveAll((int x) => (x >= currentSquare) && (x % currentNumber == 0));
                listIndex++;
            }
        }
        static void Main(string[] args)
        {
            int maxNumber = 2000000;

            var numberList = new List<int>();
            for (int i = 2; i <= maxNumber; i++)
            {
                numberList.Add(i);
            }

            SieveOfEratosthenes(numberList);

            long answer = 0;
            foreach (int primeNumber in numberList)
            {
                answer += primeNumber;
            }

            Console.WriteLine(answer);
        }
    }
}
