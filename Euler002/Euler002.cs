using System;

namespace Euler002
{
    class Euler002
    {
        static int Fibonacci(int number)
        {
            switch (number)
            {
                case 1:
                    return 1;
                case 2:
                    return 2;
                default:
                    return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
        }

        static void Main(string[] args)
        {
            int max = 4000000;
            int fibonacciCounter = 1;
            int currentFibonacci = 0;
            int answer = 0;

            while(currentFibonacci < max)
            {
                currentFibonacci = Fibonacci(fibonacciCounter);
                if(currentFibonacci % 2 == 0)
                {
                    answer += currentFibonacci;
                }
                fibonacciCounter++;
            }

            Console.WriteLine(answer);
        }
    }
}
