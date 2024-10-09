using System.Security.Cryptography.X509Certificates;

namespace Lab05;

public class RationalNumber
{
    public readonly int numerator;
    public readonly int denominator;
    public RationalNumber(int numerator, int denominator)
    {
        this.numerator = numerator/ GreatestCommonDenominator(numerator, denominator);
        this.denominator = denominator / GreatestCommonDenominator(numerator, denominator);
    }
    public static int GreatestCommonDenominator(int a, int b)
    {
        if (b == 0)
            return Math.Abs(a);
        else
            return GreatestCommonDenominator(b, a % b);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(numerator, denominator);
    }
    public override bool Equals(object? obj)
    {
        return obj.GetHashCode() == this.GetHashCode();
    }
}

public class MixedNumber
{
    readonly int WholeUnits;
    RationalNumber PartialUnits;
    public MixedNumber(int numerator, int denominator)
    {
        PartialUnits = new RationalNumber(numerator, denominator);
    }
    public MixedNumber(RationalNumber rationalNumber)
    {
        WholeUnits = ((rationalNumber.numerator - (rationalNumber.numerator % rationalNumber.denominator)) / rationalNumber.denominator);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(WholeUnits , PartialUnits.GetHashCode());
    }

    public override bool Equals(object? obj)
    {
        return obj.GetHashCode() == this.GetHashCode();
    }
}


