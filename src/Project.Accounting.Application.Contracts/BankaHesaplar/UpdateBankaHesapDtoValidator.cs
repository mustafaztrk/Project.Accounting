using System;
using Project.Accounting.Consts;
using Project.Accounting.Localization;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Project.Accounting.BankaHesaplar;

public class UpdateBankaHesapDtoValidator : AbstractValidator<UpdateBankaHesapDto>
{
    public UpdateBankaHesapDtoValidator(IStringLocalizer<AccountingResource> localizer)
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

        RuleFor(x => x.HesapTuru)
            .IsInEnum()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["AccountType"]])

            .NotEmpty()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["AccountType"]]);

        RuleFor(x => x.BankaSubeId)
            .Must(x => x.HasValue && x.Value != Guid.Empty)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["BankBranch"]]);

        RuleFor(x => x.HesapNo)
            .NotEmpty()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["AccountNumber"]])

            .MaximumLength(BankaHesapConsts.MaxHesapNoLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["AccountNumber"], BankaHesapConsts.MaxHesapNoLength]);

        RuleFor(x => x.IbanNo)
            .MaximumLength(BankaHesapConsts.MaxIbanNoLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["Iban"], BankaHesapConsts.MaxIbanNoLength]);

        RuleFor(x => x.Aciklama)
            .MaximumLength(EntityConsts.MaxAciklamaLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["Description"], EntityConsts.MaxAciklamaLength]);
    }
}