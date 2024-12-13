using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Texample
    {
        public int[] arrayx = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void FindMinMax2()
        {
            int maxValue = arrayx[0];
            int minValue = arrayx[0];

            foreach (int num in arrayx)
            {

                if (num > maxValue)
                {
                    maxValue = num;
                }
                if (num < minValue)
                {
                    minValue = num;
                }
            }
            Console.WriteLine("masiv:");
            foreach (int num in arrayx)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine($"min:{minValue} max: {maxValue}");
        }
    }
}
