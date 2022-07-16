using FluentAssertions;
using NUnit.Framework;

namespace Katalyst.Bowling;

[TestFixture]
public class ShotTests
{
    [Test]
    public void Shot_IsStrike_WhenX()
    {
        var shot = Shot.FromChar('x');
        
        shot.IsStrike().Should().BeTrue();
    }

    [Test]
    public void Shot_IsSpare_WhenBackslash()
    {
        var shot = Shot.FromChar('/');

        shot.IsSpare().Should().BeTrue();
    }
    
    [Test]
    [TestCase('0')]
    [TestCase('1')]
    [TestCase('9')]
    public void Shot_IsPinNumber_WhenValidNumber(char shotValue)
    {
        var shot = Shot.FromChar(shotValue);

        shot.IsANumberOfPins().Should().BeTrue();
    }
    [Test]
    public void Shot_ThrowsException_WhenInvalidShotValue()
    {
        Action buildInvalidShot = () => Shot.FromChar('l');

        buildInvalidShot.Should().Throw<ArgumentOutOfRangeException>();
    }
}