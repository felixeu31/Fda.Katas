using FluentAssertions;
using NUnit.Framework;

namespace Katalyst.Bowling;

[TestFixture]
public class ShotTests
{
    [Test]
    [TestCase(-1)]
    [TestCase(11)]
    public void Shot_ThrowsException_WhenInvalidShotValue(int pinsThrown)
    {
        Action buildInvalidShot = () => Shot.FromScalar(pinsThrown);

        buildInvalidShot.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Test]
    public void Shot_ValidNumberOfPins_CreateValidShot()
    {
        var shot = Shot.FromScalar(3);

        ((int)shot).Should().Be(3);
    }
    
    [Test]
    public void Shot_Strike_CreateValidShot()
    {
        var shot = Shot.FromStrike();

        ((int)shot).Should().Be(10);
    }
}