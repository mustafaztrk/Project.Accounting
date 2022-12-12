using Project.Accounting.Commons;
using Project.Accounting.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;

namespace Project.Accounting.Subeler;

public class EfCoreSubeRepository : EfCoreCommonRepository<Sube>, ISubeRepository
{
    public EfCoreSubeRepository(IDbContextProvider<AccountingDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {
    }

   
}