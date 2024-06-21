using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Provides mathematical operations.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the maximum value in a list of integers.
        /// </summary>
        /// <param name="nums">The list of integers to evaluate.</param>
        /// <returns>The maximum integer in the list, or 0 if the list is empty.</returns>
        public static int Max(List<int> nums)
        {
            int max = nums[0];

            if (nums.Count == 0)
            {
                return 0;
            }

            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }
    }
}
