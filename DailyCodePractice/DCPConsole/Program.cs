using System;
using CommonSolution;

namespace DCPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution common = new Solution();
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var result = common.ProductOfOtherElements(arr);

            PrintArray(result);

            Console.ReadLine();
        }

        static void PrintArray(int[] numbs)
        {
            foreach (var item in numbs)
            {
                Console.Write($"{item}");
                if(item != numbs[numbs.Length - 1])
                {
                    Console.Write(",");
                }
            }
        }
    }
}
