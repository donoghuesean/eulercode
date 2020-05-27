using System;

namespace Euler003
{
    class Euler003
    {
        static bool IsPrime(long number)
        {
            if (number == 1)
            {
                return false;
            }

            for (long i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static long LargestPrimeFactor(long number)
        {
            long currentPrimeFactor = 2;
            long currentNumber = number;

            for (long i = 2; i <= number / 2; i++)
            {
                if ((number % i == 0) && (IsPrime(i)))
                {
                    currentPrimeFactor = i;
                    currentNumber /= i;
                    if (currentNumber == 1)
                    {
                        break;
                    }
                }
            }

            return currentPrimeFactor;
        }

        static void Main(string[] args)
        {
            long number = 600851475143L;
            long answer = LargestPrimeFactor(number);

            Console.WriteLine(answer);
        }
    }
}
