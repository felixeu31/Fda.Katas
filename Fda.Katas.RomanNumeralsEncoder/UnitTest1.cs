namespace Fda.Katas.RomanNumeralsEncoder;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(4, "IV")]
    [TestCase(5, "V")]
    [TestCase(10, "X")]
    [TestCase(500, "D")]
    [TestCase(1000, "M")]
    [TestCase(1954, "MCMLIV")]
    [TestCase(1990, "MCMXC")]
    [TestCase(2008, "MMVIII")]
    [TestCase(2014, "MMXIV")]
    public void Test1(int value, string expected)
    {
        Assert.AreEqual(expected, RomanConvert.Solution(value));
    }
}