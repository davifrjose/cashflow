using System;
using CashFlow.Communication.Requests;
using CashFlow.Exception;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register
{
	public class RegisterExpenseValidator : AbstractValidator<RequestExpenseJson>
	{
        public RegisterExpenseValidator()
        {
            RuleFor(expense => expense.Title).NotEmpty().WithMessage(ResourceErrorMessage.TITLE_REQUIRED);
            RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage(ResourceErrorMessage.AMOUNT_HAS_TO_BE_BIGGER_THAN_ZERO);
            RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage(ResourceErrorMessage.EXPENSE_CANNOT_BE_IN_THE_FUTURE);
            RuleFor(expense => expense.paymentType).IsInEnum().WithMessage(ResourceErrorMessage.INVALID_PAYMENT_TYPE);


        }
    }    
}

