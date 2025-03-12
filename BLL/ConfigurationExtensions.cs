using BLL.Profiles;
using DAL;
using Microsoft.Extensions.DependencyInjection;

namespace BLL
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureBLL(this IServiceCollection service, string connectionString)
        {
            service.ConfigreDAL(connectionString);
            service.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
