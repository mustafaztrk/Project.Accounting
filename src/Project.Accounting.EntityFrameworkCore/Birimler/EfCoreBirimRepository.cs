using Project.Accounting.Commons;
using Project.Accounting.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Project.Accounting.Birimler;

public class EfCoreBirimRepository : EfCoreCommonRepository<Birim>, IBirimRepository
{
    public EfCoreBirimRepository(IDbContextProvider<AccountingDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }
}