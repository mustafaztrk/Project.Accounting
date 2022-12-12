using Project.Accounting.Commons;
using Project.Accounting.EntityFrameworkCore;
using Project.Accounting.Faturalar;
using Volo.Abp.EntityFrameworkCore;

namespace Project.Accounting.FaturaHareketler;

public class EfCoreFaturaHareketRepository : EfCoreCommonRepository<FaturaHareket>, 
    IFaturaHareketRepository
{
    public EfCoreFaturaHareketRepository(IDbContextProvider<AccountingDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }
}