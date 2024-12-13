using System;

namespace ConsoleApp1
{
    internal class T2 : TaskBase
    {
        private int A, B, C;

        public T2(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        private int Perimeter()
        {
            return A + B + C;
        }

        private double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override void Execute()
        {
            Console.WriteLine($"Perimetr: {Perimeter()}");
            Console.WriteLine($"Ploshcha: {Area():F2}");
        }
    }
}
