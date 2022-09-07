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

        passwordValidator.Validate("short").IsValid.Should().BeFalse();
    }

    [Test]
    public void PasswordValidator1_Invalid_WhenMissingCapitalLetter()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation1();

        passwordValidator.Validate("passwordwithoutcapital").IsValid.Should().BeFalse();
    }

    [Test]
    public void PasswordValidator1_Invalid_WhenMissingLowecase()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation1();

        passwordValidator.Validate("PASSWORDMISSINGLOWERCASE").IsValid.Should().BeFalse();
    }

    [Test]
    public void PasswordValidator1_Invalid_WhenMissingNumber()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation1();

        passwordValidator.Validate("Passwordmissingnumber").IsValid.Should().BeFalse();
    }

    [Test]
    public void PasswordValidator1_Invalid_WhenMissingUnderscore()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation1();

        var validationResult = passwordValidator.Validate("Passwordmissingundescore9");

        validationResult.IsValid.Should().BeFalse();
    }

    [Test]
    public void PasswordValidator1_Valid_WhenValidPassword()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation1();

        passwordValidator.Validate("Passwordwithcapital_1").IsValid.Should().BeTrue();
    }

    [Test]
    public void PasswordValidator2_Valid_WhenValidPassword()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation2();

        passwordValidator.Validate("Passwordwithcapital1").IsValid.Should().BeTrue();
    }

    [Test]
    public void PasswordValidator3_Valid_WhenValidPassword()
    {
        var passwordValidator = PasswordValidatorFactory.BuildValidation3();

        passwordValidator.Validate("Passwordwithcapital_").IsValid.Should().BeTrue();
    }
}