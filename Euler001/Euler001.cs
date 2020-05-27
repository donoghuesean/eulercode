using System;

namespace ProjectEuler
{
    class Euler001
    {
        static void Main(string[] args)
        {
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
                        break;
                    }
                }
            }

            Console.WriteLine(answer);
        }
    }
}
