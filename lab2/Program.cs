using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double d, x1, x2;
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());
            d = Math.Sqrt(b * b - 4 * a * c);
            if (d > 0)
            {
                x1 = (-b - d) / (2 * a);
                x2 = (-b + d) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"x = {x1}");
            }
            else
            {
                Console.WriteLine("Корней нет");
            }
        }
    }
}