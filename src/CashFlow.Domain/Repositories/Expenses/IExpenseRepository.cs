using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories.Expenses;

public interface IExpenseRepository
{
    
    Task<List<Expense>> GetAll();

    Task<Expense?> GetById(long id);
}