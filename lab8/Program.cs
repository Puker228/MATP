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
            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }

    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("230");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction Add(Fraction fraction)
        {
            int newNumerator = numerator * fraction.denominator + fraction.numerator * fraction.denominator;
            int newDenominator = denominator * fraction.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Sub(Fraction fraction)
        {
            int newNumerator = numerator * fraction.denominator - fraction.numerator * fraction.denominator;
            int newDenominator = denominator * fraction.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Mult(Fraction fraction)
        {
            int newNumerator = numerator * fraction.numerator;
            int newDenominator = denominator * fraction.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Div(Fraction fraction)
        {
            int newNumerator = numerator * fraction.denominator;
            int newDenominator = denominator * fraction.numerator;
            return new Fraction(newNumerator, newDenominator);
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }
}