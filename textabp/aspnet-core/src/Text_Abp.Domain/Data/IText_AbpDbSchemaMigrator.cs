using System.Threading.Tasks;

namespace Text_Abp.Data
{
    public interface IText_AbpDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
