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
    public void BowlingGame_WithOneShot_GetsScore(char shotValue, int expectedScore)
    {
        var game = new BowlingGame();

        game.AddShot(shotValue);

        game.Score().Should().Be(expectedScore);
    }
    
    [Test]
    [TestCase("32", 5)]
    [TestCase("33", 6)]
    [TestCase("3/", 10)]
    public void BowlingGame_WitTwoShots_GetsScore(string rollCount, int expectedScore)
    {
        var game = new BowlingGame();

        game.AddShots(rollCount);

        game.Score().Should().Be(expectedScore);
    }
    
    [Test]
    [TestCase("32|32", 10)]
    [TestCase("33|33", 12)]
    [TestCase("32|32|32|32|32|32|32|32|32|32", 50)]
    public void BowlingGame_WitRegularFrames_GetsScore(string rollCount, int expectedScore)
    {
        var game = new BowlingGame();

        game.AddShots(rollCount);

        game.Score().Should().Be(expectedScore);
    }
    
    
    [Test]
    [TestCase("3/|32", 18)]
    public void BowlingGame_WitSpareFrames_GetsScore(string rollCount, int expectedScore)
    {
        var game = new BowlingGame();

        game.AddShots(rollCount);

        game.Score().Should().Be(expectedScore);
    }
    
    [Test]
    [TestCase("x|x|21", 38)]
    public void BowlingGame_WitStrikeFrames_GetsScore(string rollCount, int expectedScore)
    {
        var game = new BowlingGame();

        game.AddShots(rollCount);

        game.Score().Should().Be(expectedScore);
    }
    
    // [Test]
    // [TestCase("X|X|X|X|X|X|X|X|X|X||XX", 38)]
    // public void BowlingGame_CompleteGames_GetsScore(string rollCount, int expectedScore)
    // {
    //     var game = new BowlingGame();
    //
    //     game.AddShots(rollCount);
    //
    //     game.Score().Should().Be(expectedScore);
    // }
}