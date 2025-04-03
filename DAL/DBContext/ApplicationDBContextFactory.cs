using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL.DBContext
{
    public class ApplicationDBContextFactory : IDesignTimeDbContextFactory<ApplicationDBContext>
    {
        public ApplicationDBContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
            optionBuilder.UseNpgsql("Host=localhost;Port=5432;Database=WTM;Username=postgres;Password=123;");
            return new ApplicationDBContext(optionBuilder.Options);
        }
    }
}
