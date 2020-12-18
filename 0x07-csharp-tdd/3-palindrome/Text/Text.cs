using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// words
    /// </summary>
    public class Str
    {
        /// <summary>
        /// palindrome
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
            {
                return (false);
            }
            if (s == "")
            {
                return (true);
            }
            string newS = s.ToLower();
            newS = Regex.Replace(newS, "[^a-z]*", "");
            char[] charArray = newS.ToCharArray();
            Array.Reverse(charArray);
            string reverseS = new string(charArray);
            if (newS == reverseS)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
}
