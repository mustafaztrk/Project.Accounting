using System;
using Project.Accounting.Consts;
using Project.Accounting.Makbuzlar;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Project.Accounting.MakbuzHareketler;

public class MakbuzHareketDtoValidator : AbstractValidator<MakbuzHareketDto>
{
    public MakbuzHareketDtoValidator(IStringLocalizer localizer)
    {
        RuleFor(x => x.Id)
            .Must(x => x.HasValue && x.Value != Guid.Empty)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Id"]]);

        RuleFor(x => x.OdemeTuru)
            .IsInEnum()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["PaymentType"]])

            .NotEmpty()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["PaymentType"]]);

        RuleFor(x => x.TakipNo)
            .NotEmpty()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["TrackingNo"]])

            .MaximumLength(MakbuzHareketConsts.MaxTakipNoLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["TrackingNo"], MakbuzHareketConsts.MaxTakipNoLength]);

        RuleFor(x => x.CekBankaId)
            .NotEmpty()
            .When(x => x.OdemeTuru == OdemeTuru.Cek)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Bank"]]);

        RuleFor(x => x.CekBankaId)
            .Empty()
            .When(x => x.OdemeTuru != OdemeTuru.Cek)
            .WithMessage(localizer[AccountingDomainErrorCodes.IsNull,
             localizer["Bank"]]);

        RuleFor(x => x.CekBankaSubeId)
            .NotEmpty()
            .When(x => x.OdemeTuru == OdemeTuru.Cek)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["BankBranch"]]);

        RuleFor(x => x.CekBankaId)
            .Empty()
            .When(x => x.OdemeTuru != OdemeTuru.Cek)
            .WithMessage(localizer[AccountingDomainErrorCodes.IsNull,
             localizer["BankBranch"]]);

        RuleFor(x => x.CekHesapNo)
            .NotEmpty()
            .When(x => x.OdemeTuru == OdemeTuru.Cek)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["CheckAccountNo"]])

            .MaximumLength(MakbuzHareketConsts.MaxCekHesapNoLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["CheckAccountNo"], MakbuzHareketConsts.MaxCekHesapNoLength]);

        RuleFor(x => x.CekHesapNo)
            .Empty()
            .When(x => x.OdemeTuru != OdemeTuru.Cek)
            .WithMessage(localizer[AccountingDomainErrorCodes.IsNull,
             localizer["CheckAccountNo"]]);

        RuleFor(x => x.BelgeNo)
            .NotEmpty()
            .When(x => x.OdemeTuru == OdemeTuru.Cek)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["CheckNo"]])

            .MaximumLength(MakbuzHareketConsts.MaxBelgeNoLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["CheckNo"], MakbuzHareketConsts.MaxBelgeNoLength]);

        RuleFor(x => x.Vade)
           .NotEmpty()
           .WithMessage(localizer[AccountingDomainErrorCodes.Required,
            localizer["Date"]]);

        RuleFor(x => x.AsilBorclu)
           .NotEmpty()
           .When(x => x.OdemeTuru == OdemeTuru.Cek || x.OdemeTuru == OdemeTuru.Senet)
           .WithMessage(localizer[AccountingDomainErrorCodes.Required,
            localizer["PrincipalDebtor"]])

           .MaximumLength(MakbuzHareketConsts.MaxAsilBorcluLength)
           .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
            localizer["PrincipalDebtor"], MakbuzHareketConsts.MaxAsilBorcluLength]);

        RuleFor(x => x.AsilBorclu)
            .Empty()
            .When(x => x.OdemeTuru != OdemeTuru.Cek && x.OdemeTuru != OdemeTuru.Senet)
            .WithMessage(localizer[AccountingDomainErrorCodes.IsNull,
             localizer["PrincipalDebtor"]]);

        RuleFor(x => x.Ciranta)
           .MaximumLength(MakbuzHareketConsts.MaxCirantaLength)
           .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
            localizer["Endorser"], MakbuzHareketConsts.MaxCirantaLength]);

        RuleFor(x => x.Ciranta)
            .Empty()
            .When(x => x.OdemeTuru != OdemeTuru.Cek && x.OdemeTuru != OdemeTuru.Senet)
            .WithMessage(localizer[AccountingDomainErrorCodes.IsNull,
             localizer["Endorser"]]);

        RuleFor(x => x.KasaId)
            .NotEmpty()
            .When(x => x.OdemeTuru == OdemeTuru.Nakit)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["CashAccount"]]);

        RuleFor(x => x.BankaHesapId)
            .NotEmpty()
            .When(x => x.OdemeTuru == OdemeTuru.Banka|| x.OdemeTuru == OdemeTuru.Pos)
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["BankAccount"]]);

        RuleFor(x => x.Tutar)
            .NotNull()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["Amount"]])

            .GreaterThanOrEqualTo(0)
            .WithMessage(localizer[AccountingDomainErrorCodes.GreaterThanOrEqual,
             localizer["Amount"], localizer["ToZero"], localizer["ThanZero"]]);

        RuleFor(x => x.BelgeDurumu)
            .IsInEnum()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["MeansOfPaymentState"]])

            .NotEmpty()
            .WithMessage(localizer[AccountingDomainErrorCodes.Required,
             localizer["MeansOfPaymentState"]]);

        RuleFor(x => x.Aciklama)
            .MaximumLength(EntityConsts.MaxAciklamaLength)
            .WithMessage(localizer[AccountingDomainErrorCodes.MaxLenght,
             localizer["Description"], EntityConsts.MaxAciklamaLength]);
    }
}