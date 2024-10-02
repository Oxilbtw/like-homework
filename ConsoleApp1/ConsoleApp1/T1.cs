namespace ConsoleApp1
{
    internal class T1
    {
        const int N = 23;
        internal class Ta1 : TaskBase
        {
            const int N = 23;

            public override void Execute()
            {
                int[] numbers = { 1, 10, 30 };
                Console.WriteLine($"Числа, якi належать iнтервалу [1, {N}]:");
                foreach (int elem in numbers)
                {
                    if (elem >= 1 && elem <= N)
                        Console.WriteLine(elem);
                }
            }
        }
    }
}
