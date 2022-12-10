using Project.Accounting.Commons;
using System.Threading.Tasks;

namespace Project.Accounting.Subeler;

public interface ISubeRepository : ICommonRepository<Sube>
{
    Task EntityAnyAsync(Guid? subeId, Func<object, bool> value);
}