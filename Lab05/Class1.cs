namespace Lab05;

public class RationalNumber
{
    readonly int numerator;
    readonly int denominator;
    public RationalNumber(int numerator, int denominator)
    {
        this.numerator = GreatestCommonDenominator(numerator, denominator);
        this.denominator = GreatestCommonDenominator(denominator, numerator);
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
    MixedNumber mixedNumber;
    public MixedNumber(int numerator, int denominator)
    {
        mixedNumber = new MixedNumber(new RationalNumber(numerator, denominator));
    }
    public MixedNumber(RationalNumber rationalNumber)
    {

    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
}


