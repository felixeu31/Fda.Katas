using FluentAssertions;

namespace Katalyst.Bowling;

public class BowlingGameTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase('3', 3)]
    [TestCase('2', 2)]
    [TestCase('x', 10)]
    public void one_pin_score(char shotValue, int expectedScore)
    {
        var game = new BowlingGame();

        game.AddShot(shotValue);

        game.Score().Should().Be(expectedScore);
    }
    
    [Test]
    [TestCase("32", 5)]
    [TestCase("33", 6)]
    [TestCase("3/", 10)]
    public void two_pin_score(string rollCount, int expectedScore)
    {
        var game = new BowlingGame();

        game.AddShots(rollCount);

        game.Score().Should().Be(expectedScore);
    }
}