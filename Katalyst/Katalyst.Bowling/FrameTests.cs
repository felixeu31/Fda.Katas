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
    public void Frame_IsStrike_When10PinsDownWithOneShot()
    {
        var frame = new Frame(1);
        
        frame.AddShot('x');
        
        frame.IsStrike().Should().BeTrue();
    }

    [Test]
    public void Shot_IsSpare_WhenBackslash()
    {
        var frame = new Frame(1);
        
        frame.AddShot('6');
        frame.AddShot('/');

        frame.IsSpare().Should().BeTrue();
    }
    
}