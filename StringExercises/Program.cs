using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = "I would not, could not, in a box. I would not, could not with a fox.\nI will not eat them in a house. I will not eat them with a mouse.";
            //string[] myWords = myStr.Split(' ');
            //Console.WriteLine(string.Join(",", myWords));
            string[] mySentences = myStr.Split('.');
            Console.WriteLine(string.Join("/", mySentences));
        }
    }
}
