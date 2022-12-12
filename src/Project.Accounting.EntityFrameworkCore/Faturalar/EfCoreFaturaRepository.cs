using System.Linq;
using System.Threading.Tasks;
using Project.Accounting.Commons;
using Project.Accounting.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Project.Accounting.Faturalar;

public class EfCoreFaturaRepository : EfCoreCommonRepository<Fatura>, IFaturaRepository
{
    public EfCoreFaturaRepository(IDbContextProvider<AccountingDbContext> dbContextProvider)
        : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Fatura>> WithDetailsAsync()
    {
        return (await GetQueryableAsync())
            .Include(x => x.Cari)
            .Include(x => x.OzelKod1)
            .Include(x => x.OzelKod2)

            .Include(x => x.FaturaHareketler).ThenInclude(x => x.Depo)

            .Include(x => x.FaturaHareketler).ThenInclude(x => x.Stok)
                                             .ThenInclude(x => x.Birim)

            .Include(x => x.FaturaHareketler).ThenInclude(x => x.Hizmet)
                                             .ThenInclude(x => x.Birim)

            .Include(x => x.FaturaHareketler).ThenInclude(x => x.Masraf)
                                             .ThenInclude(x => x.Birim);
    }
}