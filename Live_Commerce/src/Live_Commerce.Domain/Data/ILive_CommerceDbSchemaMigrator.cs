using System.Threading.Tasks;

namespace Live_Commerce.Data
{
    public interface ILive_CommerceDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
