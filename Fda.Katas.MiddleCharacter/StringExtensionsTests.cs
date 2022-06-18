namespace Fda.Katas.MiddleCharacter
{
    public class StringExtensionsTests
    {
        [TestCase("")]
        [TestCase("aa")]
        [TestCase("aaaa")]
        [TestCase("aabbccddee")]
        public void Even(string input)
        {
            Assert.IsTrue(input.IsEven());
        }
        
        [TestCase("a")]
        [TestCase("aaa")]
        [TestCase("aabbccdde")]
        public void Odd(string input)
        {
            Assert.IsFalse(input.IsEven());
        }
    }
}