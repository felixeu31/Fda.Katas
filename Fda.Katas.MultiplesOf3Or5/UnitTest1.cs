namespace Fda.Katas.MultiplesOf3Or5;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.AreEqual(23, Kata.Solution(10));
        Assert.AreEqual(45, Kata.Solution(13));
        Assert.AreEqual(0, Kata.Solution(-13));
    }
}