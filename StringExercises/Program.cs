using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            string[] newArray = myString.Split(".");
            Console.WriteLine(string.Join(",", newArray));
            //Console.WriteLine("Hello Strings!");
        }
    }
}
