using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;

namespace CashFlow.Application.UseCases.Expenses.Register;

public interface IUpdateExpenseUseCase
{

    Task Execute(long id, RequestExpenseJson request);
}