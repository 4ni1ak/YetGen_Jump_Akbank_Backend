using FluentValidation.API.Models;
using FluentValidation.Domain.Entities;

namespace FluentValidation.API.Validators
{
    public class BankAccountValidator:AbstractValidator<GetBankAccountDataResponseModel>
    {

        public BankAccountValidator()
        {
            RuleFor(x => x.Balance).NotEmpty().NotNull().WithMessage("Balance not be null ");
            RuleFor(x => x.FirstName).NotEmpty().NotNull().WithMessage("FirstName not be null ");


        }
    }
}
