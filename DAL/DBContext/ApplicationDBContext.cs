using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<WorkTask> Tasks { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<UserProperty> UserProperties { get; set; }
        public DbSet<Role> Roles { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {}
    }
}
