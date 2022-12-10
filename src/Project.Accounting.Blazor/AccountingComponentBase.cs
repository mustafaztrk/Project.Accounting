using Project.Accounting.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Project.Accounting.Blazor;

public abstract class AccountingComponentBase : AbpComponentBase
{
    protected AccountingComponentBase()
    {
        LocalizationResource = typeof(AccountingResource);
    }
}
