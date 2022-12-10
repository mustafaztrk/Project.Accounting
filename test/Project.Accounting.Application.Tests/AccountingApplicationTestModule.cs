using Volo.Abp.Modularity;

namespace Project.Accounting;

[DependsOn(
    typeof(AccountingApplicationModule),
    typeof(AccountingDomainTestModule)
    )]
public class AccountingApplicationTestModule : AbpModule
{

}
