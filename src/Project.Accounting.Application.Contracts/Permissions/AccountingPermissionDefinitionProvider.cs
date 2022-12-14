using Project.Accounting.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Project.Accounting.Permissions;

public class AccountingPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var localizePrefix = "Permission";
        var mainGroup = context.AddGroup(AccountingPermissions.GroupName,
            L($"{localizePrefix}:{AccountingPermissions.GroupName}"));

        //ayar
        var ayar = mainGroup.AddPermission(AccountingPermissions.Ayar.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Ayar)}"));

        //banka
        var banka = mainGroup.AddPermission(AccountingPermissions.Banka_.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Banka_)}"));

        banka.AddChild(AccountingPermissions.Banka_.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Banka_)}{AccountingPermissions.CreateConst}"));//Permission:Banka.Create
        banka.AddChild(AccountingPermissions.Banka_.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Banka_)}{AccountingPermissions.UpdateConst}"));//Permission:Banka.Update
        banka.AddChild(AccountingPermissions.Banka_.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Banka_)}{AccountingPermissions.DeleteConst}"));
        banka.AddChild(AccountingPermissions.Banka_.Transaction,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Banka_)}{AccountingPermissions.TransactionConst}"));

        //banka hesap
        var bankaHesap = mainGroup.AddPermission(AccountingPermissions.BankaHesap.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.BankaHesap)}"));

        bankaHesap.AddChild(AccountingPermissions.BankaHesap.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.BankaHesap)}{AccountingPermissions.CreateConst}"));
        bankaHesap.AddChild(AccountingPermissions.BankaHesap.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.BankaHesap)}{AccountingPermissions.UpdateConst}"));
        bankaHesap.AddChild(AccountingPermissions.BankaHesap.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.BankaHesap)}{AccountingPermissions.DeleteConst}"));
        bankaHesap.AddChild(AccountingPermissions.BankaHesap.Transaction,
            L($"{localizePrefix}:{nameof(AccountingPermissions.BankaHesap)}{AccountingPermissions.TransactionConst}"));

        //banka şube
        var bankaSube = mainGroup.AddPermission(AccountingPermissions.BankaSube.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.BankaSube)}"));

        bankaSube.AddChild(AccountingPermissions.BankaSube.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.BankaSube)}{AccountingPermissions.CreateConst}"));
        bankaSube.AddChild(AccountingPermissions.BankaSube.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.BankaSube)}{AccountingPermissions.UpdateConst}"));
        bankaSube.AddChild(AccountingPermissions.BankaSube.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.BankaSube)}{AccountingPermissions.DeleteConst}"));

        //birim
        var birim = mainGroup.AddPermission(AccountingPermissions.Birim.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Birim)}"));

        birim.AddChild(AccountingPermissions.Birim.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Birim)}{AccountingPermissions.CreateConst}"));
        birim.AddChild(AccountingPermissions.Birim.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Birim)}{AccountingPermissions.UpdateConst}"));
        birim.AddChild(AccountingPermissions.Birim.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Birim)}{AccountingPermissions.DeleteConst}"));

        //cari
        var cari = mainGroup.AddPermission(AccountingPermissions.Cari.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Cari)}"));

        cari.AddChild(AccountingPermissions.Cari.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Cari)}{AccountingPermissions.CreateConst}"));
        cari.AddChild(AccountingPermissions.Cari.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Cari)}{AccountingPermissions.UpdateConst}"));
        cari.AddChild(AccountingPermissions.Cari.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Cari)}{AccountingPermissions.DeleteConst}"));
        cari.AddChild(AccountingPermissions.Cari.Transaction,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Cari)}{AccountingPermissions.TransactionConst}"));

        //depo
        var depo = mainGroup.AddPermission(AccountingPermissions.Depo.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Depo)}"));

        depo.AddChild(AccountingPermissions.Depo.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Depo)}{AccountingPermissions.CreateConst}"));
        depo.AddChild(AccountingPermissions.Depo.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Depo)}{AccountingPermissions.UpdateConst}"));
        depo.AddChild(AccountingPermissions.Depo.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Depo)}{AccountingPermissions.DeleteConst}"));
        depo.AddChild(AccountingPermissions.Depo.Transaction,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Depo)}{AccountingPermissions.TransactionConst}"));

        //donem
        var donem = mainGroup.AddPermission(AccountingPermissions.Donem.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Donem)}"));

        donem.AddChild(AccountingPermissions.Donem.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Donem)}{AccountingPermissions.CreateConst}"));
        donem.AddChild(AccountingPermissions.Donem.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Donem)}{AccountingPermissions.UpdateConst}"));
        donem.AddChild(AccountingPermissions.Donem.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Donem)}{AccountingPermissions.DeleteConst}"));

        //fatura
        var fatura = mainGroup.AddPermission(AccountingPermissions.Fatura.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Fatura)}"));

        fatura.AddChild(AccountingPermissions.Fatura.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Fatura)}{AccountingPermissions.CreateConst}"));
        fatura.AddChild(AccountingPermissions.Fatura.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Fatura)}{AccountingPermissions.UpdateConst}"));
        fatura.AddChild(AccountingPermissions.Fatura.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Fatura)}{AccountingPermissions.DeleteConst}"));
        fatura.AddChild(AccountingPermissions.Fatura.Print,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Fatura)}{AccountingPermissions.PrintConst}"));

        //hizmet
        var hizmet = mainGroup.AddPermission(AccountingPermissions.Hizmet.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Hizmet)}"));

        hizmet.AddChild(AccountingPermissions.Hizmet.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Hizmet)}{AccountingPermissions.CreateConst}"));
        hizmet.AddChild(AccountingPermissions.Hizmet.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Hizmet)}{AccountingPermissions.UpdateConst}"));
        hizmet.AddChild(AccountingPermissions.Hizmet.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Hizmet)}{AccountingPermissions.DeleteConst}"));
        hizmet.AddChild(AccountingPermissions.Hizmet.Transaction,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Hizmet)}{AccountingPermissions.TransactionConst}"));

        //kasa
        var kasa = mainGroup.AddPermission(AccountingPermissions.Kasa.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Kasa)}"));

        kasa.AddChild(AccountingPermissions.Kasa.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Kasa)}{AccountingPermissions.CreateConst}"));
        kasa.AddChild(AccountingPermissions.Kasa.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Kasa)}{AccountingPermissions.UpdateConst}"));
        kasa.AddChild(AccountingPermissions.Kasa.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Kasa)}{AccountingPermissions.DeleteConst}"));
        kasa.AddChild(AccountingPermissions.Kasa.Transaction,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Kasa)}{AccountingPermissions.TransactionConst}"));

        //makbuz
        var makbuz = mainGroup.AddPermission(AccountingPermissions.Makbuz.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Makbuz)}"));

        makbuz.AddChild(AccountingPermissions.Makbuz.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Makbuz)}{AccountingPermissions.CreateConst}"));
        makbuz.AddChild(AccountingPermissions.Makbuz.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Makbuz)}{AccountingPermissions.UpdateConst}"));
        makbuz.AddChild(AccountingPermissions.Makbuz.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Makbuz)}{AccountingPermissions.DeleteConst}"));
        makbuz.AddChild(AccountingPermissions.Makbuz.Print,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Makbuz)}{AccountingPermissions.PrintConst}"));

        //masraf
        var masraf = mainGroup.AddPermission(AccountingPermissions.Masraf.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Masraf)}"));

        masraf.AddChild(AccountingPermissions.Masraf.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Masraf)}{AccountingPermissions.CreateConst}"));
        masraf.AddChild(AccountingPermissions.Masraf.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Masraf)}{AccountingPermissions.UpdateConst}"));
        masraf.AddChild(AccountingPermissions.Masraf.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Masraf)}{AccountingPermissions.DeleteConst}"));
        masraf.AddChild(AccountingPermissions.Masraf.Transaction,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Masraf)}{AccountingPermissions.TransactionConst}"));

        //odemebelgesi
        var odemeBelgesi = mainGroup.AddPermission(AccountingPermissions.OdemeBelgesi.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.OdemeBelgesi)}"));

        //odemeBelgesi.AddChild(AccountingPermissions.OdemeBelgesi.Create,
        //    L($"{localizePrefix}:{nameof(AccountingPermissions.OdemeBelgesi)}{AccountingPermissions.CreateConst}"));
        //odemeBelgesi.AddChild(AccountingPermissions.OdemeBelgesi.Update,
        //    L($"{localizePrefix}:{nameof(AccountingPermissions.OdemeBelgesi)}{AccountingPermissions.UpdateConst}"));
        //odemeBelgesi.AddChild(AccountingPermissions.OdemeBelgesi.Delete,
        //    L($"{localizePrefix}:{nameof(AccountingPermissions.OdemeBelgesi)}{AccountingPermissions.DeleteConst}"));

        //ozelKod
        var ozelKod = mainGroup.AddPermission(AccountingPermissions.OzelKod.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.OzelKod)}"));

        ozelKod.AddChild(AccountingPermissions.OzelKod.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.OzelKod)}{AccountingPermissions.CreateConst}"));
        ozelKod.AddChild(AccountingPermissions.OzelKod.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.OzelKod)}{AccountingPermissions.UpdateConst}"));
        ozelKod.AddChild(AccountingPermissions.OzelKod.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.OzelKod)}{AccountingPermissions.DeleteConst}"));

        // stok
        var stok = mainGroup.AddPermission(AccountingPermissions.Stok.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Stok)}"));

        stok.AddChild(AccountingPermissions.Stok.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Stok)}{AccountingPermissions.CreateConst}"));
        stok.AddChild(AccountingPermissions.Stok.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Stok)}{AccountingPermissions.UpdateConst}"));
        stok.AddChild(AccountingPermissions.Stok.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Stok)}{AccountingPermissions.DeleteConst}"));
        stok.AddChild(AccountingPermissions.Stok.Transaction,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Stok)}{AccountingPermissions.TransactionConst}"));

        // sube
        var sube = mainGroup.AddPermission(AccountingPermissions.Sube.Default,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Sube)}"));

        sube.AddChild(AccountingPermissions.Sube.Create,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Sube)}{AccountingPermissions.CreateConst}"));
        sube.AddChild(AccountingPermissions.Sube.Update,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Sube)}{AccountingPermissions.UpdateConst}"));
        sube.AddChild(AccountingPermissions.Sube.Delete,
            L($"{localizePrefix}:{nameof(AccountingPermissions.Sube)}{AccountingPermissions.DeleteConst}"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AccountingResource>(name);
    }
}
