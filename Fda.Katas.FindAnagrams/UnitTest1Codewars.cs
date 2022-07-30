namespace Fda.Katas.FindAnagrams;
using System.Linq;

public class TestsCodewars
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(new List<string> {"a"}, KataCodeWars.Anagrams("a", new List<string> {"a", "b", "c", "d"}));
        Assert.AreEqual(new List<string> {"carer", "arcre", "carre"}, KataCodeWars.Anagrams("racer", new List<string> {"carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr"}));
    }
}


public static class KataCodeWars
{
    public static List<string> Anagrams(string word, List<string> words)
    {
        return words.FindAll(s => 
            s.OrderBy(c => c)
                .SequenceEqual(word.OrderBy(c => c)));
    }
  
}