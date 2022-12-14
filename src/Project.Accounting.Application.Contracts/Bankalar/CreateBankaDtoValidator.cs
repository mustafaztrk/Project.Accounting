using Project.Accounting.Consts;
using Project.Accounting.Localization;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Project.Accounting.Bankalar;

public class CreateBankaDtoValidator:AbstractValidator<CreateBankaDto>
{
    public CreateBankaDtoValidator(IStringLocalizer<AccountingResource> localizer)
    {
        RuleFor(x => x.Kod)
            .NotEmpty()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required, localizer["Code"]])

            .MaximumLength(EntityConsts.MaxKodLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght, localizer["Code"],
             EntityConsts.MaxKodLength]);

        RuleFor(x => x.Ad)
            .NotEmpty()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required, localizer["Name"]])

            .MaximumLength(EntityConsts.MaxAdLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght, localizer["Name"],
             EntityConsts.MaxAdLength]);

        RuleFor(x => x.Aciklama)
            .MaximumLength(EntityConsts.MaxAciklamaLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["Description"], EntityConsts.MaxAciklamaLength]);
    }
}