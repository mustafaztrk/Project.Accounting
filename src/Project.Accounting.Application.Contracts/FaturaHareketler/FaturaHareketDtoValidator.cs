using System;
using Project.Accounting.Consts;
using Project.Accounting.Faturalar;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Project.Accounting.FaturaHareketler;

public class FaturaHareketDtoValidator : AbstractValidator<FaturaHareketDto>
{
    public FaturaHareketDtoValidator(IStringLocalizer localizer)
    {
        RuleFor(x => x.Id)
            .Must(x => x.HasValue && x.Value != Guid.Empty)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Id"]]);

        RuleFor(x => x.HareketTuru)
            .IsInEnum()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["RowType"]])

            .NotEmpty()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["RowType"]]);

        RuleFor(x => x.StokId)
            .NotEmpty()
            .When(x => x.HareketTuru == FaturaHareketTuru.Stok)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Stock"]]);

        RuleFor(x => x.HizmetId)
            .NotEmpty()
            .When(x => x.HareketTuru == FaturaHareketTuru.Hizmet)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Service"]]);

        RuleFor(x => x.MasrafId)
            .NotEmpty()
            .When(x => x.HareketTuru == FaturaHareketTuru.Masraf)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Expense"]]);

        RuleFor(x => x.DepoId)
            .NotEmpty()
            .When(x => x.HareketTuru == FaturaHareketTuru.Stok)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Warehouse"]]);

        RuleFor(x => x.Miktar)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Quantity"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["Quantity"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.BirimFiyat)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["UnitPrice"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["UnitPrice"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.BrutTutar)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["GrossAmount"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["GrossAmount"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.IndirimTutar)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["DiscountAmount"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["DiscountAmount"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.KdvOrani)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["ValueAddedTaxRate"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["ValueAddedTaxRate"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.KdvHaricTutar)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["ExcludesValueAddedTaxAmount"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["ExcludesValueAddedTaxAmount"], localizer["ToZero"],
             localizer["ThanZero"]]);

        RuleFor(x => x.KdvTutar)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["ValueAddedTaxAmount"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["ValueAddedTaxAmount"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.NetTutar)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["TotalAmount"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["TotalAmount"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.Aciklama)
            .MaximumLength(EntityConsts.MaxAciklamaLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["Description"], EntityConsts.MaxAciklamaLength]);
    }
}