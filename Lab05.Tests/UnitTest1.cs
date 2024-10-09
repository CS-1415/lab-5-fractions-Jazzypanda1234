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
        Debug.Assert(RationalNumber.GreatestCommonDenominator(4,6) == 2);
    }
}