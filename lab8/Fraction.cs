namespace lab8;

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
        int newNumerator = numerator * fraction.denominator + fraction.numerator * denominator;
        int newDenominator = denominator * fraction.denominator;
        return simple(new Fraction(newNumerator, newDenominator));
    }

    public Fraction Sub(Fraction fraction)
    {
        int newNumerator = numerator * fraction.denominator - fraction.numerator * denominator;
        int newDenominator = denominator * fraction.denominator;
        return simple(new Fraction(newNumerator, newDenominator));
    }

    public Fraction Mult(Fraction fraction)
    {
        int newNumerator = numerator * fraction.numerator;
        int newDenominator = denominator * fraction.denominator;
        return simple(new Fraction(newNumerator, newDenominator));
    }

    public Fraction Div(Fraction fraction)
    {
        int newNumerator = numerator * fraction.denominator;
        int newDenominator = denominator * fraction.numerator;
        return simple(new Fraction(newNumerator, newDenominator));
    }
    
    private Fraction simple(Fraction fraction)
    {
        int gcd = GCD(fraction.numerator, fraction.denominator);
        return new Fraction(fraction.numerator / gcd, fraction.denominator / gcd);
    }
    
    private int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }

        return a;
    }
    
    public override string ToString()
    {
        return numerator + "/" + denominator;
    }
}