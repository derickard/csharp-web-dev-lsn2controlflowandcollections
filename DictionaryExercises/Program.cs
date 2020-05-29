using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string studentName;
            Regex rgx = new Regex(@"^[a-zA-Z]+$");  // This is to test that student name is letters only
            int studentNumber;


            do
            {
                Console.Write("\nEnter Student Name, ENTER to quit: ");
                studentName = Console.ReadLine();
                if (!Equals(studentName, ""))
                {
                    // try to check student name is letters only
                    try
                    {
                        if (!rgx.IsMatch(studentName))
                        {
                            throw new FormatException();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Student's names are letters only");
                        continue;
                    }

                    // Get valid student number, integers only
                    Console.Write("Enter Student ID Number: ");
                    while(!int.TryParse(Console.ReadLine(), out studentNumber))
                    {
                        Console.Write("Student IDs are integers only, try again. What is {0}'s student ID: ", studentName);
                    }
                    students[studentNumber] = studentName;
                }

            } while (!Equals(studentName, ""));

            // Print roster
            Console.WriteLine("\nName\tID\n---\t--");
            foreach(KeyValuePair<int,string>s in students)
            {
                Console.WriteLine("{0}\t{1}", s.Value, s.Key);
            }
        }
    }
}
