using System;

namespace CommonSolution
{
    public class Solution
    {
        /// <summary>
        /// Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
        ///For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
        ///Bonus: Can you do this in one pass?
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="special"></param>
        /// <returns></returns>
        public bool AreSumOfTwoNumbersEqualTo(int[] numbers, int special)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j && (numbers[i] + numbers[j] == special))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
