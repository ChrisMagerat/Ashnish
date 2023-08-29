using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolverQuestion
{
    internal class Program
    {
        static int GetCharIndex(char letter)
        {
            char[] alphabetArr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            int index = Array.IndexOf(alphabetArr, Char.ToUpper(letter));

            return index;
        }

        static int mod(int x, int m)
        {
            return (x % m + m) % m;
        }

        static int getCyclicDifference(char char1, char char2)
        {
            int char1Index = GetCharIndex(char1);
            int char2Index = GetCharIndex(char2);

            int Char1_2 = GetCharIndex(char1) - GetCharIndex(char2);
            int Char2_1 = GetCharIndex(char2) - GetCharIndex(char1);

            int cyclicDifference = Math.Min(mod(Char1_2, 26), mod(Char2_1, 26));

            return cyclicDifference;
        }

        static double getTimeDifference(char char1, char char2)
        {
            int cyclicDifference = getCyclicDifference(char1, char2);
            if (cyclicDifference == 0) 
            {
                return 2.5;            
            }
            else
            {
                return cyclicDifference * 5;
            }
        }


        static double CalculateDuration(string inputString)
        {
            char[] inputCharArr = inputString.ToCharArray();

            int windowSize = 2;

            double timeCounter = 0;

            for (int i = 0; i < inputCharArr.Length - windowSize + 1; i++)
            {
                timeCounter += getTimeDifference(inputCharArr[i], inputCharArr[i + 1]);
            }

            return timeCounter;
        }


    static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What string would you like to write out:");
                string userInput = Console.ReadLine();
                double timeTaken = CalculateDuration('A' + userInput);
                Console.WriteLine("The time it would take to write out the word " + userInput + " would be " + timeTaken + " seconds");
            }
        }
    }
}
