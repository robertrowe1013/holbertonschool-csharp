using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// maths
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// max int
        /// </summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return (0);
            }
            List<int> sorted = new List<int>(nums);
            sorted.Sort();
            int max = sorted[sorted.Count -1];

            return (max);
        }
    }
}
