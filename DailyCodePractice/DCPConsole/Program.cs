using System;
using CommonSolution;

namespace DCPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution common = new Solution();
            var arr = new int[] { 10, 15, 3, 7 };
            var specialNumber = 10;

            Console.WriteLine(common.AreSumOfTwoNumbersEqualTo(arr, specialNumber));

            Console.ReadLine();
        }
    }
}
