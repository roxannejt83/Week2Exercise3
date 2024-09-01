using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise3
{
    internal class VowelCounter // Declares class that contains the main method where the execution starts
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: "); // Prompt the user to enter a string
            string input = Console.ReadLine(); // Read the input from the user
            input = input.ToLower(); // Convert the input string to lowercase to handle both uppercase and lowercase vowels
            int vowelCount = 0; // Initialize a variable to count the number of vowels
            string vowels = "aeiou"; // Define a string containing all vowels for easy checking
            foreach (char ch in input) // Use a foreach loop to iterate through each character in the input string
            {
                if (vowels.Contains(ch)) // Check if the current character is a vowel
                {
                    vowelCount++; // If it is a vowel, increment the vowel count
                }
            }
            Console.WriteLine(" The number of vowels in the string is: " + vowelCount +".  Press 'Enter' to exit."); // Display the result to the user
            Console.ReadLine(); // Wait to close
        }
    }
}
