namespace CashFlow.Application.UseCases.Expenses.Register.Reports;

public interface IGenerateExpenseReportExcelUseCase
{
    Task<byte[]> Execute(DateOnly month);
}