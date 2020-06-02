/* Counting Sundays
 * Problem 19
 * https://projecteuler.net/problem=19
 */

using System;

namespace Euler019
{
    class Euler019
    {
        static void Main(string[] args)
        {
            int totalSundays = 0;

            for (int year = 1901; year <= 2000; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    DateTime date = new DateTime(year, month, 1);
                    if (date.DayOfWeek == 0)
                    {
                        totalSundays++;
                    }
                }
            }

            Console.WriteLine(totalSundays);
        }
    }
}
