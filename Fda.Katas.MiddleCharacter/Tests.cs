namespace Fda.Katas.MiddleCharacter;

public class KataTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GenericTests()
    {
        Assert.AreEqual("es",Kata.GetMiddle("test"));
    }
    [Test]
    public void GenericTests2()
    {
        Assert.AreEqual("t",Kata.GetMiddle("testing"));
    }
    [Test]
    public void GenericTests3()
    {
        Assert.AreEqual("dd",Kata.GetMiddle("middle"));
    }
    [Test]
    public void GenericTests4()
    {
        Assert.AreEqual("A",Kata.GetMiddle("A"));
    }
}