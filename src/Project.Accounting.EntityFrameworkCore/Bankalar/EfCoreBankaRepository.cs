using Project.Accounting.Commons;
using Project.Accounting.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Project.Accounting.Bankalar;

public class EfCoreBankaRepository : EfCoreCommonRepository<Banka>, IBankaRepository
{
    public EfCoreBankaRepository(IDbContextProvider<AccountingDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }
}