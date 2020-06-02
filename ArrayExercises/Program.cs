using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numberArray = { 1, 1, 2, 3, 5, 8 };
            foreach (int number in numberArray)
            {
                if (number % 2 > 0)
                {
                   Console.WriteLine(number);
                }
                
            }
            //Console.WriteLine(numberArray[0]);
        }
    }
}
