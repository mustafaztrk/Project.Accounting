using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Project.Accounting.Commons;

public interface ICommonNoKeyRepository<TEntity> : IRepository<TEntity>
    where TEntity : class, IEntity //id alanı olmayan entityler  için kullan/  raporlar
{
    Task<TEntity> FromSqlRawSingleAsync(string sql, params object[] parameters);
    Task<IList<TEntity>> FromSqlRawAsync(string sql, params object[] parameters);
}