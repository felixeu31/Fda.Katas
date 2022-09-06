using FluentAssertions;
using NUnit.Framework;
using PasswordValidation.Validations;

namespace PasswordValidation.Tests.Tests;

[TestFixture]
public class ValidationTests
{
    [Test]
    public void MinimumCharacterValidation_Invalid_WhenNotMinimumCharacters()
    {
        var validation = new MinimumCharacterValidation(8);

        validation.IsValid("short").Should().BeFalse();
    }
    [Test]
    public void MinimumCharacterValidation_Valid_WhenLarger()
    {
        var validation = new MinimumCharacterValidation(8);

        validation.IsValid("largerinput").Should().BeTrue();
    }

    [Test]
    public void UpperCaseValidation_Invalid_WhenMissingCapitalLetter()
    {
        var validation = new UpperCaseValidation();

        validation.IsValid("short").Should().BeFalse();
    }
    [Test]
    public void UpperCaseValidation_Valid_WhenCapitalLetter()
    {
        var validation = new UpperCaseValidation();

        validation.IsValid("Capital").Should().BeTrue();
    }

    [Test]
    public void LowerCaseValidation_Invalid_WhenMissingCapitalLetter()
    {
        var validation = new LowerCaseValidation();

        validation.IsValid("ALLUPPER").Should().BeFalse();
    }
    [Test]
    public void LowerCaseValidation_Valid_WhenCapitalLetter()
    {
        var validation = new LowerCaseValidation();

        validation.IsValid("lOWER").Should().BeTrue();
    }

    [Test]
    public void NumberCaseValidation_Invalid_WhenMissingCapitalLetter()
    {
        var validation = new NumberCaseValidation();

        validation.IsValid("password").Should().BeFalse();
    }
    [Test]
    public void NumberCaseValidation_Valid_WhenCapitalLetter()
    {
        var validation = new NumberCaseValidation();

        validation.IsValid("paswor5").Should().BeTrue();
    }

    [Test]
    public void UnderScoreCaseValidation_Invalid_WhenMissingUnderScore()
    {
        var validation = new UnderScoreCaseValidation();

        validation.IsValid("password").Should().BeFalse();
    }
    [Test]
    public void UnderScoreCaseValidation_Valid_WhenUnderScore()
    {
        var validation = new UnderScoreCaseValidation();

        validation.IsValid("passwor_").Should().BeTrue();
    }
}