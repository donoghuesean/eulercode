/* Smallest multiple
 * Problem 5
 * https://projecteuler.net/problem=5
 */

using System;

namespace Euler005
{
    class Euler005
    {
        static bool Divisible1To20(int number)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (number % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int number = 20;
            while (Divisible1To20(number) == false)
            {
                number++;
            }
            Console.WriteLine(number);
        }
    }
}
