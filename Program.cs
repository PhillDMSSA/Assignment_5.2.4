using System;

namespace Assignment_5._2._4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine().ToUpper(); 

            
            bool result = IsPalindrome(input, 0, input.Length - 1);

            
            if (result)
            {
                Console.WriteLine("The string is Palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not Palindrome.");
            }

        }
        public static bool IsPalindrome(string str, int start, int end)
        {

            if (start >= end)
            {
                return true;
            }


            if (str[start] != str[end])
            {
                return false;
            }

            // Recursively check the substring
            return IsPalindrome(str, start + 1, end - 1);
        }




    }
}
