using AutoMapper;
using CashFlow.Communication.Requests;
using CashFlow.Domain.Repositories;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionBase;
using Microsoft.Extensions.Options;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class UpdateExpenseUseCase : IUpdateExpenseUseCase
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IExpenseUpdateOnlyRepository _repository;

    public UpdateExpenseUseCase(IUnitOfWork unitOfWork, IMapper mapper,IExpenseUpdateOnlyRepository repository)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _repository = repository;
    }
    public async Task Execute(long id, RequestExpenseJson request)
    {
        Validate(request);

        var expense = await _repository.GetById(id);

        if (expense is null)
        {
            throw new NotFoundException(ResourceErrorMessage.EXPENSE_NOT_FOUND);
        }

        _mapper.Map(request, expense);
        _repository.Update(expense);
        
        await _unitOfWork.Commit(); 
    }
    
    private void Validate(RequestExpenseJson request)
    {
        var validator = new RegisterExpenseValidator();

        var result = validator.Validate(request);

        if(result.IsValid == false)
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errorMessages);
        }

			
    }
}