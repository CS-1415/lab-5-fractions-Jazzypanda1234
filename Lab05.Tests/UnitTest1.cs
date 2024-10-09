using System.Diagnostics;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Lab05.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Debug.Assert(RationalNumber.GreatestCommonDenominator(4,0) == 4);
        Debug.Assert(RationalNumber.GreatestCommonDenominator(8,12) == 4);
        Debug.Assert(RationalNumber.GreatestCommonDenominator(24,18) == 6);
        Debug.Assert(RationalNumber.GreatestCommonDenominator(10,15) == 5);
        Debug.Assert(RationalNumber.GreatestCommonDenominator(2,3) == 1);
    }

    [Test]
    public void Test2()
    {
        new RationalNumber(2, 4);
        new RationalNumber(8, -4);
        new RationalNumber(-9, 3);
        new RationalNumber(-10, -15);
    }

    [Test]
    public void Test3()
    {
        RationalNumber rationalNumber;
        Debug.Assert(new RationalNumber(10, 15).Equals(new RationalNumber(2, 3)));
        Debug.Assert(new RationalNumber(2,3).Equals(new RationalNumber(2,3)));
        Debug.Assert(new RationalNumber(20,10).Equals(new RationalNumber(4,2)));
    }

    [Test]
    public void Test4()
    {
        new MixedNumber(10, 8);
        new MixedNumber(8, 10);
    }

    [Test]
    public void Test5()
    {
        new MixedNumber(125, 50).Equals(new MixedNumber(5,2));
    }
}