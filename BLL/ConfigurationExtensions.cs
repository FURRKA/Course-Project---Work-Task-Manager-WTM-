using BLL.DTO;
using BLL.Interfaces;
using BLL.Profiles;
using BLL.Services;
using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;

namespace BLL
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureBLL(this IServiceCollection service, string connectionString)
        {
            service.ConfigreDAL(connectionString);
            service.AddAutoMapper(typeof(MappingProfile));
            service.AddTransient<IService<Project, ProjectDTO>, ProjectService>();
            service.AddTransient<IService<DAL.Entities.Task, TaskDTO>, TaskService>(); 
            service.AddTransient<IService<Company, CompanyDTO>, CompanyService>(); 
            service.AddTransient<IService<Tag, TagDTO>, TagService>(); 
            service.AddTransient<IService<Comment, CommentDTO>, CommentService>();
        }

        public static void Log(this ModelStateDictionary model)
        {
            model.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .ToList().ForEach(Console.WriteLine);
        }
    }
}
