using DAL.DBContext;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class ConfigurationExtensions
    {
        public static void ConfigreDAL(this IServiceCollection service, string connectionString)
        {
            //service.AddTransient<IRepository<User>, UserRepository>();
            service.AddTransient<IRepository<Comment>, CommentRepository>();
            service.AddTransient<IRepository<Company>, CompanyRepository>();
            service.AddTransient<IRepository<Tag>, TagRepository>();
            service.AddTransient<IRepository<Entities.Task>, TaskRepository>();
            service.AddTransient<IRepository<Project>, ProjectRepository>();
            service.AddDbContext<ApplicationDBContext>(options => options.UseLazyLoadingProxies().UseNpgsql(connectionString));
            service.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
