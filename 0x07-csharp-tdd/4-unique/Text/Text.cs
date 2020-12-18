using System;

namespace Text
{
    /// <summary>
    /// words
    /// </summary>
    public class Str
    {
        /// <summary>
        /// unique
        /// </summary>
        public static int UniqueChar(string s)
        {
            if (s == null || s.Length ==0)
            {
                return (-1);
            }
            int num;
            for (int i = 0; i < s.Length; i++)
            {
                num = 0;
                for (int i2 = 0; i2 < s.Length; i2++)
                {
                    if (s[i] == s[i2])
                    {
                        num++;
                    }
                }
                if (num == 1)
                {
                    return (i);
                }
            }
            return (-1);
        }
    }
}
