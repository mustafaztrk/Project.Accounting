﻿using Project.Accounting.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Project.Accounting.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AccountingEntityFrameworkCoreModule),
    typeof(AccountingApplicationContractsModule)
    )]
public class AccountingDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
