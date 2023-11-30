using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double c;
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            c = 2 * (x * x * x * x) - 3 * x * x * x - 5 * x + 6;
            Console.WriteLine($"C = {c}");
        }
    }
}