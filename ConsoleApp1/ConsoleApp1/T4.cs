using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class T4 : TaskBase
    {
        int M = 1;
        public int[] arrayx = { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public int[] arrayy;

        public T4()
        {
            arrayy = arrayx.Where(x => Math.Abs(x) > M).ToArray();
        }

        public override void Execute()
        {
            Console.WriteLine("Задане число М: " + M);
            Console.WriteLine("Масив X: " + string.Join(", ", arrayx));
            Console.WriteLine("Отриманий масив Y: " + string.Join(", ", arrayy));
        }
    }

}
