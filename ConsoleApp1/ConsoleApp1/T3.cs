using System;

namespace ConsoleApp1
{
    internal class T3 : TaskBase
    {
        public int[] arrayx = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        public override void Execute()
        {
            int minValue = arrayx[0];
            int maxValue = arrayx[0];

            foreach (int num in arrayx)
            {
                if (num < minValue)
                {
                    minValue = num;
                }
                if (num > maxValue)
                {
                    maxValue = num;
                }
            }

            Console.WriteLine("Масив:");
            foreach (int num in arrayx)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine($"Min: {minValue}");
            Console.WriteLine($"Max: {maxValue}");
        }
    }
}
