/*
Implement an algorithm to determine if a string has all unique characters
*/
using System;

namespace UniqueCharacters
{
    class Program
    {
        static void UniqueCharacters(string word)
        {
            // Declare and Init coutner variable
            int duplicateCount = 0;
            
            // Convert string into an array
            char[] charArr = word.ToCharArray();

            // iterate through the array - nested for loop
            for (var i = 0; i < charArr.Length; i++)
            {
                // J index to evaluate another index in the array to compare to i
                for (var j = i+ 1; j < charArr.Length; j++)
                {
                    if (charArr[i] == charArr[j])
                    {
                        // if the values are equal, implies there are duplicates / Not Unique
                        duplicateCount++;
                    }
                }
            }
            // duplicateCount value determines if string contains all unique characters
            if (duplicateCount == 0)
            {
                Console.WriteLine("The string has all unique letters");
            }
            else
            {
                Console.WriteLine("The string has duplicate letters");
            }
        }
        static void Main(string[] args)
        {
            string testString = "Timothy";
            UniqueCharacters(testString);

            string test2 = "Apple";
            UniqueCharacters(test2);
        }
    }
}
/*
Space Complexity Big O = O(n) Time
*/