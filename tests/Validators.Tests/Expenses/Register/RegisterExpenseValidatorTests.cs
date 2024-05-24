using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Exception;
using CommonTestUtilities.Requests;
using FluentAssertions;
using Xunit;

namespace Validators.Tests.Expenses.Register;

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
      // Arrange
      var validator = new RegisterExpenseValidator();
      var request = RequestExpenseJsonBuilder.Build();
      
      // Act
      var result = validator.Validate(request);
      // Assert
      result.IsValid.Should().BeTrue();
    }

    [Fact]
    public void Error_Title_Empty()
    {
        // Arrange
        var validator = new RegisterExpenseValidator();
        var request = RequestExpenseJsonBuilder.Build();
        request.Title = string.Empty;
      
        // Act
        var result = validator.Validate(request);
        // Assert
        result.IsValid.Should().BeFalse();
        result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessage.TITLE_REQUIRED));
    }
    
    [Fact]
    public void Error_Date_Future()
    {
        // Arrange
        var validator = new RegisterExpenseValidator();
        var request = RequestExpenseJsonBuilder.Build();
        request.Date = DateTime.UtcNow.AddDays(1);
      
        // Act
        var result = validator.Validate(request);
        // Assert
        result.IsValid.Should().BeFalse();
        result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessage.EXPENSE_CANNOT_BE_IN_THE_FUTURE));
    } 
    
    [Fact]
    public void Error_Payment_Type_Invalid()
    {
        // Arrange
        var validator = new RegisterExpenseValidator();
        var request = RequestExpenseJsonBuilder.Build();
        request.paymentType = (PaymentType)700;
      
        // Act
        var result = validator.Validate(request);
        // Assert
        result.IsValid.Should().BeFalse();
        result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessage.INVALID_PAYMENT_TYPE));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    
    public void Error_Amount_Invalid(decimal amount)
    {
        // Arrange
        var validator = new RegisterExpenseValidator();
        var request = RequestExpenseJsonBuilder.Build();
        request.Amount = amount;
      
        // Act
        var result = validator.Validate(request);
        // Assert
        result.IsValid.Should().BeFalse();
        result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessage.AMOUNT_HAS_TO_BE_BIGGER_THAN_ZERO));
    }
}