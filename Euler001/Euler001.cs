/* Multiples of 3 and 5  
* Problem 1
* https://projecteuler.net/problem=1
*/

using System;

namespace ProjectEuler
{
    class Euler001
    {
        static void Main(string[] args)
        {
            // 'end' and the integers in the 'multiples' array can be changed to work with other numbers
            int end = 1000;
            int[] multiples = {3, 5};

            int answer = 0;
            for (int i = 1; i < end; i++)
            {
                foreach (int multiple in multiples)
                {
                    if (i % multiple == 0)
                    {
                        answer += i;
                        break; // Avoids one number counting twice
                    }
                }
            }

            Console.WriteLine(answer);
        }
    }
}
