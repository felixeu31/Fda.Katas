using FluentAssertions;
using PasswordValidation.Factories;

namespace PasswordValidation.Tests.Tests;

public class PaswordValidatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PasswordValidator1_Invalid_WhenNotMinimumCharacters()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation1();

        passwordValidator.IsValid("short").Should().BeFalse();
    }

    [Test]
    public void PasswordValidator1_Invalid_WhenMissingCapitalLetter()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation1();

        passwordValidator.IsValid("passwordwithoutcapital").Should().BeFalse();
    }

    [Test]
    public void PasswordValidator1_Invalid_WhenMissingLowecase()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation1();

        passwordValidator.IsValid("PASSWORDMISSINGLOWERCASE").Should().BeFalse();
    }

    [Test]
    public void PasswordValidator1_Invalid_WhenMissingNumber()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation1();

        passwordValidator.IsValid("Passwordmissingnumber").Should().BeFalse();
    }

    [Test]
    public void PasswordValidator1_Invalid_WhenMissingUnderscore()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation1();

        passwordValidator.IsValid("Passwordmissingundescore9").Should().BeFalse();
    }

    [Test]
    public void PasswordValidator1_Valid_WhenValidPassword()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation1();

        passwordValidator.IsValid("Passwordwithcapital_1").Should().BeTrue();
    }

    [Test]
    public void PasswordValidator2_Valid_WhenValidPassword()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation2();

        passwordValidator.IsValid("Passwordwithcapital1").Should().BeTrue();
    }

    [Test]
    public void PasswordValidator3_Valid_WhenValidPassword()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation3();

        passwordValidator.IsValid("Passwordwithcapital_").Should().BeTrue();
    }
}