/* Names scores
 * Problem 22
 * https://projecteuler.net/problem=22
 */

using System;
using System.IO;

namespace Euler022
{
    class Euler022
    {
        static int GetNameScore(string name, int placeInArray)
        {
            int nameScore = 0;

            foreach(char letter in name)
            {
                nameScore += letter - 64; // char values of letters start at 65
            }

            nameScore *= placeInArray;

            return nameScore;
        }

        static void Main(string[] args)
        {
            string textFilePath = "C:\\p022_names.txt"; // Change this to the path of the names.txt file on your machine

            // Reading from file
            StreamReader namesFile = new StreamReader(textFilePath);
            string namesString = namesFile.ReadLine();
            namesFile.Close();

            // Setting up array
            namesString = namesString.Replace("\"", "");
            string[] namesArray = namesString.Split(",");
            Array.Sort(namesArray);

            // Calculating scores
            int totalNamesScores = 0;
            for (int i = 0; i < namesArray.Length; i++)
            {
                totalNamesScores += GetNameScore(namesArray[i], i + 1);
            }

            Console.WriteLine(totalNamesScores);
        }
    }
}
