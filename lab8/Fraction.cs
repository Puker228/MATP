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