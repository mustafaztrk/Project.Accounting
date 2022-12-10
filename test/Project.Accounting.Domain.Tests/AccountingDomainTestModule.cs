using Project.Accounting.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Project.Accounting;

[DependsOn(
    typeof(AccountingEntityFrameworkCoreTestModule)
    )]
public class AccountingDomainTestModule : AbpModule
{

}
