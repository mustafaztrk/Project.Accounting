using System;
using Project.Accounting.Consts;
using Project.Accounting.Localization;
using Project.Accounting.MakbuzHareketler;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Project.Accounting.Makbuzlar;

public class CreateMakbuzDtoValidator : AbstractValidator<CreateMakbuzDto>
{
    public CreateMakbuzDtoValidator(IStringLocalizer<AccountingResource> localizer)
    {
        RuleFor(x => x.MakbuzTuru)
            .IsInEnum()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["ReceiptType"]])

            .NotEmpty()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["ReceiptType"]]);

        RuleFor(x => x.MakbuzNo)
            .NotEmpty()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["ReceiptNo"]])

            .MaximumLength(MakbuzConsts.MaxMakbuzNoLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["ReceiptNo"], MakbuzConsts.MaxMakbuzNoLength]);

        RuleFor(x => x.Tarih)
            .NotEmpty()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Date"]]);

        RuleFor(x => x.KasaId)
            .NotEmpty()
            .When(x => x.MakbuzTuru == MakbuzTuru.KasaIslem)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Cash"]]);

        RuleFor(x => x.KasaId)
            .Empty()
            .When(x => x.MakbuzTuru != MakbuzTuru.KasaIslem)
            .WithMessage(localizer[AccountingDomainErrorCodes.IsNull,
             localizer["Cash"]]);

        RuleFor(x => x.CariId)
            .NotEmpty()
            .When(x => x.MakbuzTuru == MakbuzTuru.Tahsilat || x.MakbuzTuru == MakbuzTuru.Odeme)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Customer"]]);

        RuleFor(x => x.CariId)
            .Empty()
            .When(x => x.MakbuzTuru != MakbuzTuru.Tahsilat && x.MakbuzTuru != MakbuzTuru.Odeme)
            .WithMessage(localizer[AccountingDomainErrorCodes.IsNull,
             localizer["Customer"]]);

        RuleFor(x => x.BankaHesapId)
            .NotEmpty()
            .When(x => x.MakbuzTuru == MakbuzTuru.BankaIslem)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["BankAccount"]]);

        RuleFor(x => x.BankaHesapId)
            .Empty()
            .When(x => x.MakbuzTuru != MakbuzTuru.BankaIslem)
            .WithMessage(localizer[AccountingDomainErrorCodes.IsNull,
             localizer["BankAccount"]]);

        RuleFor(x => x.HareketSayisi)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["NumberOfTransactions"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["NumberOfTransactions"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.CekToplam)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["CheckTotal"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["CheckTotal"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.SenetToplam)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["BillOfExchangeTotal"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["BillOfExchangeTotal"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.PosToplam)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["PosTotal"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["PosTotal"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.NakitToplam)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["CashTotal"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["CashTotal"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.BankaToplam)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["BankTotal"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["BankTotal"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.SubeId)
            .Must(x => x.HasValue && x.Value != Guid.Empty)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Branch"]]);

        RuleFor(x => x.DonemId)
            .Must(x => x.HasValue && x.Value != Guid.Empty)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Period"]]);

        RuleFor(x => x.Aciklama)
            .MaximumLength(EntityConsts.MaxAciklamaLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["Description"], EntityConsts.MaxAciklamaLength]);

        RuleForEach(x => x.MakbuzHareketler)
            .SetValidator(y => new MakbuzHareketDtoValidator(localizer));
    }
}