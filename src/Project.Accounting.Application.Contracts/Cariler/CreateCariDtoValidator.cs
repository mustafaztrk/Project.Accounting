using Project.Accounting.Consts;
using Project.Accounting.Localization;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Project.Accounting.Cariler;

public class CreateCariDtoValidator:AbstractValidator<CreateCariDto>
{
    public CreateCariDtoValidator(IStringLocalizer<AccountingResource> localizer)
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

        RuleFor(x => x.VergiDairesi)
            .MaximumLength(CariConsts.MaxVergiDairesiLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["TaxAdministration"], CariConsts.MaxVergiDairesiLength]);

        RuleFor(x => x.VergiNo)
            .MaximumLength(CariConsts.MaxVergiNoLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["TaxNumber"], CariConsts.MaxVergiNoLength]);

        RuleFor(x => x.Telefon)
            .MaximumLength(EntityConsts.MaxTelefonLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["Telephone"], EntityConsts.MaxTelefonLength]);

        RuleFor(x => x.Adres)
            .MaximumLength(EntityConsts.MaxAdresLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["Address"], EntityConsts.MaxAdresLength]);

        RuleFor(x => x.Aciklama)
            .MaximumLength(EntityConsts.MaxAciklamaLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["Description"], EntityConsts.MaxAciklamaLength]);
    }
}