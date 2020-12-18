using System;

namespace Text
{
    /// <summary>
    /// words
    /// </summary>
    public class Str
    {
        /// <summary>
        /// word count
        /// </summary>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length == 0)
            {
                return (0);
            }
            int count = 1;
            foreach (char i in s)
            {
                if (i >= 65 && i <= 90)
                {
                    count++;
                }
            }
            return (count);
        }
    }
}
