using BLL.DTO;
using BLL.Interfaces;
using BLL.Profiles;
using BLL.Services;
using DAL;
using DAL.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace BLL
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureBLL(this IServiceCollection service, string connectionString)
        {
            service.ConfigreDAL(connectionString);
            service.AddAutoMapper(typeof(MappingProfile));
            service.AddTransient<IService<Project, ProjectDTO>, ProjectService>();
            service.AddTransient<IService<WorkTask, TaskDTO>, TaskService>(); 
            service.AddTransient<IService<Company, CompanyDTO>, CompanyService>(); 
            service.AddTransient<IService<Tag, TagDTO>, TagService>(); 
        }
    }
}
