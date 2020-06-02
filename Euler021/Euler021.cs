/* Amicable numbers
 * Problem 21
 * https://projecteuler.net/problem=21
 */

using System;
using System.Collections.Generic;

namespace Euler021
{
    class Euler021
    {
        static Dictionary<int, int> divisorSums = new Dictionary<int, int>(); // Stores (n, d(n)) pairs where d(n) is the sum of proper divisors of n
        static List<int> amicableNumbers = new List<int>(); // Stores numbers that are part of an amicable pair where d(a) = b, d(b) = a, a =/= b

        static int SumOfDivisors(int number)
        {
            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if(number % i == 0)
                {
                    sum += i;
                }
            }

            divisorSums.Add(number, sum);
            return sum;
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 10000; i++)
            {
                SumOfDivisors(i);
            }

            foreach(int num in divisorSums.Keys)
            {
                if (divisorSums.ContainsKey(divisorSums[num]) // if a = d(b)
                    && divisorSums[divisorSums[num]] == num   // and b = d(a)
                    && num != divisorSums[num])               // and a =/= b
                {
                    if(amicableNumbers.Contains(num) == false)
                    {
                        amicableNumbers.Add(num);
                    }
                    if(amicableNumbers.Contains(divisorSums[num]) == false)
                    {
                        amicableNumbers.Add(divisorSums[num]);
                    }
                }
            }

            int amicableSum = 0;
            foreach(int amicableNumber in amicableNumbers)
            {
                amicableSum += amicableNumber;
            }

            Console.WriteLine(amicableSum);
        }
    }
}
