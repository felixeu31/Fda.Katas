# Password validation kata

This [kata](https://katalyst.codurance.com/password-validation?utm_content=213945523&utm_medium=social&utm_source=twitter&hss_channel=tw-722314876216086528) is from [Katalyst Codurance](https://katalyst.codurance.com/)

# Project condifiguration
Dependencies:

- NUnit
- Fluent Assertions

# Development journal

## Iteration 1
As a requirement for the kata is applying TDD as practice for the development process.

- So in the first place I create the a Test. This test will be for the first condition of minimum number characters
- In that test I have to instantiate a PasswordValidator which leads me to create a new Class "PasswordValidator"
- As I have a preference for FluentAssertions I install the package in this step
- I create an assertions to validate that a short password throws a false result, in this moment I create the method "IsValid" in the previous class
- Then as the test compiles I run the test and it fails because a non implemented exception. Then I start with the first implementation of the method.

This is the general process followed to apply TDD in this kata, from now the journal will be resumed

- Introducing the tests for the second validation it breaks one of my prior tests

```
[Test]
public void ValidateMinimunCharacters_Valid_WhenLarge()
{
    var passwordValidator = new PasswordValidator();
    
    passwordValidator.IsValid("largepassword").Should().BeTrue();
}
```

This doesn't pass the test because the string provided has no capital letter. That leads me to an interesting question:

- Is my design well suited for testing? Is modular enough? If my validator stops working how I am going to know the cause? I will surely to debug and find out wich rule is not working?
- Should I think about another design that allows me to encapsulate and test each rule without cross dependencies?

As the KATA has 2 iterations I decided to do a simpler solution and then improve it in the next iteration


## Iteration 2

- In order to encapsulate every validation I decided to create a generic abstraction
- Then I followed TDD creating test and separated implementations for each validation
- Then I rewritted the PasswordValidatorTestsOop to test the new implementation of the PasswordValidatorOop usin the news validations
- Then I created a Factory class to build different PasswordValidations with specific validations
- Then I created a Builder class
- Then I refactor some methods ensuring all tests pass

## Iteration 3
- Add the output error messages to the validation result
- Realize that I had to change all test that validates validation resutls

## Iteration 4
- Add permitted errors feature