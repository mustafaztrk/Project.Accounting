using Project.Accounting.Commons;
using Project.Accounting.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Project.Accounting.Parametreler;

public class EfCoreFirmaParametreRepository : EfCoreCommonRepository<FirmaParametre>, IFirmaParametreRepository
{
    public EfCoreFirmaParametreRepository(IDbContextProvider<AccountingDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }
}
