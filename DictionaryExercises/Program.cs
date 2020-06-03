using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, string> GradebookDictionary = new Dictionary<double, string>();
            GradebookDictionary.Add(123, "Daryn");
            GradebookDictionary.Add(456, "Dave");
            GradebookDictionary.Add(789, "Miguel");
            GradebookDictionary.Add(111, "Jed");
            GradebookDictionary.Add(777, "Moe");
            
            Console.Write("Enter a Student ID:");
            int studentID = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a Student name:");
            string studentName = Console.ReadLine();
            if (studentID != 0 && studentName != "")
            {
                GradebookDictionary.Add(studentID, studentName);
            }
            foreach (KeyValuePair<double, string> id in GradebookDictionary)
            {
                Console.WriteLine(id.Key + "." + "-" + id.Value);
            }
            {

            }
            
            
        }
    }
}
