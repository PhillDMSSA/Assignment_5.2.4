using System;

namespace Assignment_5._2._4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("The string is Palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not Palindrome.");
            }
        }

        static bool IsPalindrome(string str)
        {
            return IsPalindromeRecursive(str, 0, str.Length - 1);
        }

        static bool IsPalindromeRecursive(string str, int left, int right)
        {
            if (left >= right)
            {
                return true; // Base case: Checked all pairs
            }

            if (str[left] != str[right])
            {
                return false; // Characters do not match
            }

            // Recursive call to check next pair
            return IsPalindromeRecursive(str, left + 1, right - 1);
        }

        // Alternative check using a for loop for comparison
        static bool IsPalindromeWithLoop(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
