using System;
using System.Collections.Generic;
using System.Data;

namespace ListExercises
{
    class Program
    {
        public static void numLetters(List<string> words)
        {
            Console.Write("Enter a word length:");
            int userDefinedLength = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length == userDefinedLength)
                {
                    Console.WriteLine(words[i]);
                }
            }
            
                
                

            
        }
        public static int EvenNums(List<int> nums){
            int totalSumEvens = 0;
         foreach (int num in nums)
	     {
           if(num % 2 == 0){
           totalSumEvens+= num;

           } 
	     }
            
            return totalSumEvens;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine(EvenNums(numbers));
            List<string> wordsList = new List<string>{"stuff","things","words","this","that"};
            numLetters(wordsList);
        }
    }
}
