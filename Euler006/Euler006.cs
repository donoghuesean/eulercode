/* Sum square difference
 * Problem 6
 * https://projecteuler.net/problem=6
 */

using System;

namespace Euler006
{
    class Euler006
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
            }

            int squareOfSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                squareOfSum += i;
            }
            squareOfSum *= squareOfSum;

            int sumSquareDifference = squareOfSum - sumOfSquares;

            Console.WriteLine(sumSquareDifference);
        }
    }
}
