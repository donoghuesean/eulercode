using System;

namespace Euler009
{
    class Euler009
    {
        static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            if (a < b && b < c)
            {
                if (a*a + b*b == c*c)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int answer = 0;
            for (int a = 1; a < 1000; a++)
            {
                for (int b = a; b < 1000; b++)
                {
                    for (int c = b; c < 1000; c++)
                    {
                        if (a + b + c == 1000)
                        {
                            if (IsPythagoreanTriplet(a, b, c))
                            {
                                answer = a * b * c;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
