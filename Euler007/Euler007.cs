using System;

namespace Euler007
{
    class Euler007
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
        static void Main(string[] args)
        {
            int primesFound = 0;
            int currentNumber = 0;
            while (primesFound < 10001)
            {
                currentNumber++;
                if (IsPrime(currentNumber))
                {
                    primesFound++;
                }
            }
            Console.WriteLine(currentNumber);
        }
    }
}
