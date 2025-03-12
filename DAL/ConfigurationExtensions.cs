﻿using DAL.DBContext;
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
            service.AddTransient<IRepository<User>, UserRepository>();
            service.AddTransient<IRepository<Comment>, CommentRepository>();
            service.AddTransient<IRepository<Tag>, TagRepository>();
            service.AddTransient<IRepository<WorkTask>, TaskRepository>();
            service.AddTransient<IRepository<Project>, ProjectRepository>();
            service.AddDbContext<ApplicationDBContext>(options => options.UseNpgsql(connectionString));
            service.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
