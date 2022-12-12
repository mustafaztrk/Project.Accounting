using Project.Accounting.Commons;
using Project.Accounting.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Project.Accounting.Raporlar;

public class EfCoreGirenCikanBakiyeRepository : EfCoreCommonNoKeyRepository<GirenCikanBakiye>,
    IGirenCikanBakiyeRepository
{
    public EfCoreGirenCikanBakiyeRepository(IDbContextProvider<AccountingDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {
    }
}