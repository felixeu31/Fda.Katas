namespace Fda.Katas.FindAnagrams;
using System.Linq;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(new List<string> {"a"}, Kata.Anagrams("a", new List<string> {"a", "b", "c", "d"}));
        Assert.AreEqual(new List<string> {"carer", "arcre", "carre"}, Kata.Anagrams("racer", new List<string> {"carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr"}));
    }
}


public static class Kata
{
    public static List<string> Anagrams(string word, List<string> words)
    {
        return words.Where(x => IsAnagram(x, word)).ToList();
        
    }
  
    public static bool IsAnagram(string word1, string word2)
    {
        return word1.Length == word2.Length
               && word1.Distinct().All(x => word1.Count(c => c.Equals(x)) 
                                            == word2.Count(c => c.Equals(x)));
    }
}