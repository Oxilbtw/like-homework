using System;
using static ConsoleApp1.T1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskBase[] tasks = new TaskBase[] { new Ta1(), new T2(3, 4, 5), new T3(), new T4() };

            foreach (TaskBase task in tasks)
            {
                task.Execute();
                Console.WriteLine();
            }
        }
    }
}
