using System;

namespace Text
{
    /// <summary>
    /// Provides operations related to strings.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines whether the specified string is a palindrome.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns><c>true</c> if the specified string is a palindrome; otherwise, <c>false</c>.</returns>
        public static bool IsPalindrome(string s)
        {
            string palindrome = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                palindrome += s[i];
            }

            if (s == palindrome)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
