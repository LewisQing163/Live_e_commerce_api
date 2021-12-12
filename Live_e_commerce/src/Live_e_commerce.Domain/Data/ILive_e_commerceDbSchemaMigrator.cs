using System.Threading.Tasks;

namespace Live_e_commerce.Data
{
    public interface ILive_e_commerceDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
