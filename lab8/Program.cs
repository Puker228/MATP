using System;

namespace lab8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Числитель первой дроби: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Знаменатель первой дроби: ");
            int den1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("\nЧислитель второй дроби: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Знаменатель второй дроби: ");
            int den2 = Convert.ToInt32(Console.ReadLine());
            
            Fraction fr1 = new Fraction(num1, den1);
            Fraction fr2 = new Fraction(num2, den2);

            Fraction add = fr1.Add(fr2);
            Fraction sub = fr1.Sub(fr2);
            Fraction mult = fr1.Mult(fr2);
            Fraction div = fr1.Div(fr2);
            Console.WriteLine($"\nadd: {add}");
            Console.WriteLine($"sub: {sub}");
            Console.WriteLine($"mult: {mult}");
            Console.WriteLine($"div: {div}");
        }
    }
}