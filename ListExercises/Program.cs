using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myInts = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<string> myStrings = new List<string> { "add", "subtract", "divide", "horse", "goat", "wagon" };
            string myStr = "I would not, could not, in a box. I would not, could not with a fox.\nI will not eat them in a house. I will not eat them with a mouse.";
            List<string> mySplitString = myStr.Split(" ").ToList();
            int mySum = Sum(myInts);
            myInts.ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine("\nSum is {0}", mySum);
            Console.Write("How long word to search for: ");
            int wordLength = int.Parse(Console.ReadLine());
            PrintString(wordLength, myStrings);
            PrintString(wordLength, mySplitString);
        }

        static int Sum(List<int> ints)
        {
            int sum = 0;
            foreach(int i in ints)
            {
                sum += i;
            }
            return sum;
        }

        static void PrintString(int length, List<string> str)
        {
            foreach(string s in str)
            {
                if(s.Length == length)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
