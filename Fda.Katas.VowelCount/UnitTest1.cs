using NUnit.Framework;

namespace Fda.Katas.VowelCount
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
        }
        [Test]
        public void TestCaseBestSolution()
        {
            Assert.AreEqual(5, Kata.GetVowelCountBestSolution("abracadabra"), "Nope!");
        }
    }
}