using Project.Accounting.Commons;
using Project.Accounting.EntityFrameworkCore;
using Project.Accounting.Makbuzlar;
using Volo.Abp.EntityFrameworkCore;

namespace Project.Accounting.MakbuzHareketler;

public class EfCoreMakbuzHareketRepository : EfCoreCommonRepository<MakbuzHareket>, IMakbuzHareketRepository
{
    public EfCoreMakbuzHareketRepository(IDbContextProvider<AccountingDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {
    }
}