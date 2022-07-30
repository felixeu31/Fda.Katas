using FluentAssertions;
using NUnit.Framework;

namespace Katalyst.Bowling;

[TestFixture]
public class FrameTests
{
    [Test]
    public void RegularFrame_AddOneShot_ScoreIncrementsAccord()
    {
        var frame = new Frame(1);

        frame.AddShot('3');

        frame.Score().Should().Be(3);
    }
    
    [Test]
    public void RegularFrame_AddTwoShots_ScoreIncrementsAccord()
    {
        var frame = new Frame(1);

        frame.AddShot('3');
        frame.AddShot('3');

        frame.Score().Should().Be(6);
    }
    
    [Test]
    public void RegularFrame_AddTwoShots_IsCompleted()
    {
        var frame = new Frame(1);

        frame.AddShot('3');
        frame.AddShot('3');

        frame.IsCompleted().Should().BeTrue();
    }
    
    
    [Test]
    public void RegularFrame_AddThreeShots_ThrowException()
    {
        var frame = new Frame(1);

        frame.AddShot('3');
        frame.AddShot('3');

        Action buildInvalidShot = () => frame.AddShot('3');

        buildInvalidShot.Should().Throw<Exception>();
    }
    
    [Test]
    public void Frame_When10PinsDownWithOneShot_IsStrike()
    {
        var frame = new Frame(1);
        
        frame.AddShot('x');
        
        frame.IsStrike().Should().BeTrue();
    }
    
    
    [Test]
    public void Frame_WhenStrikeSymbolInSecondShot_ThrowEx()
    {
        var frame = new Frame(1);
        
        frame.AddShot('3');
        Action buildInvalidShot = () => frame.AddShot('x');

        buildInvalidShot.Should().Throw<Exception>();
    }
    
    
    [Test]
    public void Frame_WhenSpareSymbolInSecondShot_ThrowEx()
    {
        var frame = new Frame(1);
        
        Action buildInvalidShot = () => frame.AddShot('/');

        buildInvalidShot.Should().Throw<Exception>();
    }

    [Test]
    public void Shot_WhenBackslash_IsSpare()
    {
        var frame = new Frame(1);
        
        frame.AddShot('6');
        frame.AddShot('/');

        frame.IsSpare().Should().BeTrue();
    }
    
    
    
    [Test]
    public void Frame_WithStrike_ScoresTen()
    {
        var frame = new Frame(1);

        frame.AddShot('x');

        frame.Score().Should().Be(10);
    }
    
    [Test]
    public void Frame_WithStrike_IsCompleted()
    {
        var frame = new Frame(1);

        frame.AddShot('x');

        frame.IsCompleted().Should().BeTrue();
    }
    
    
    [Test]
    public void Frame_InvalidShotSymbol_ThrowEx()
    {
        var frame = new Frame(1);

        Action buildInvalidShot = () => frame.AddShot('X');

        buildInvalidShot.Should().Throw<ArgumentOutOfRangeException>();
    }
    
}