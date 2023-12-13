using System;

namespace lab8
{
    class Program
    {
        static void Main()
        {
            Fraction fr1 = new Fraction(1, 2);
            Fraction fr2 = new Fraction(3, 4);

            Fraction add = fr1.Add(fr2);
            Fraction sub = fr1.Sub(fr2);
            Fraction mult = fr1.Mult(fr2);
            Fraction div = fr1.Div(fr2);
            Console.WriteLine($"add: {add}");
            Console.WriteLine($"sub: {sub}");
            Console.WriteLine($"mult: {mult}");
            Console.WriteLine($"div: {div}");
        }
    }
}