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
    [TestCase(3)]
    [TestCase(10)]
    public void Shot_ValidNumberOfPins_CreateValidShot(int pinsInput)
    {
        var shot = Shot.FromScalar(pinsInput);

        ((int)shot).Should().Be(pinsInput);
    }
}