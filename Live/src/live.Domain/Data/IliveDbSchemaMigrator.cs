using System.Threading.Tasks;

namespace live.Data
{
    public interface IliveDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
