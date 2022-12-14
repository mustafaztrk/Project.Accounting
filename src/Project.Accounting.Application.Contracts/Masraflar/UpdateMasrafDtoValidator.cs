using System;
using Project.Accounting.Consts;
using Project.Accounting.Localization;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Project.Accounting.Masraflar;

public class UpdateMasrafDtoValidator : AbstractValidator<UpdateMasrafDto>
{
    public UpdateMasrafDtoValidator(IStringLocalizer<AccountingResource> localizer)
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

        RuleFor(x => x.KdvOrani)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["ValueAddedTaxRate"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["ValueAddedTaxRate"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.BirimFiyat)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["UnitPrice"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["UnitPrice"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.Barkod)
            .MaximumLength(EntityConsts.MaxBarkodLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["BarCode"], EntityConsts.MaxBarkodLength]);

        RuleFor(x => x.BirimId)
            .Must(x => x.HasValue && x.Value != Guid.Empty)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Unit"]]);

        RuleFor(x => x.Aciklama)
            .MaximumLength(EntityConsts.MaxAciklamaLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["Description"], EntityConsts.MaxAciklamaLength]);
    }
}