using Project.Accounting.Commons;
using Project.Accounting.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Project.Accounting.BankaSubeler;

public class EfCoreBankaSubeRepository : EfCoreCommonRepository<BankaSube>, IBankaSubeRepository
{
    public EfCoreBankaSubeRepository(IDbContextProvider<AccountingDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }
}