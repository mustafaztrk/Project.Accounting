using System;
using System.Collections.Generic;
using System.Text;
using Project.Accounting.Localization;
using Volo.Abp.Application.Services;

namespace Project.Accounting;

/* Inherit your application services from this class.
 */
public abstract class AccountingAppService : ApplicationService
{
    protected AccountingAppService()
    {
        LocalizationResource = typeof(AccountingResource);
    }
}
