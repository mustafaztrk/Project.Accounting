using System.Threading.Tasks;

namespace Project.Accounting.Data;

public interface IAccountingDbSchemaMigrator
{
    Task MigrateAsync();
}
