/* Largest palindrome product
 * Problem 4
 * https://projecteuler.net/problem=4
 */

using System;

namespace Euler004
{
    class Euler004
    {
        static bool IsPalindrome(string input)
        {
            char[] inputChars = input.ToCharArray();
            Array.Reverse(inputChars);
            string inputReversed = new string(inputChars);

            return (input == inputReversed);
        }

        static bool IsPalindrome(int input)
        {
            return IsPalindrome(Convert.ToString(input));
        }

        static void Main(string[] args)
        {
            int answer = 0;

            for (int i = 999; i >= 100; i--)
            {
                for (int j = i; j >= 100; j--)
                {
                    int product = i * j;
                    if (IsPalindrome(product))
                    {
                        if (product > answer)
                        {
                            answer = product;
                        }
                    }
                }
            }

            Console.WriteLine(answer);
        }
    }
}
