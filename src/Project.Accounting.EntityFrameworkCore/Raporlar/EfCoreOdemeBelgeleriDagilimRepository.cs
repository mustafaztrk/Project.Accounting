using Project.Accounting.Commons;
using Project.Accounting.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Project.Accounting.Raporlar;

public class EfCoreOdemeBelgeleriDagilimRepository : EfCoreCommonNoKeyRepository<OdemeBelgeleriDagilim>,
    IOdemeBelgeleriDagilimRepository
{
    public EfCoreOdemeBelgeleriDagilimRepository(IDbContextProvider<AccountingDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {
    }
}