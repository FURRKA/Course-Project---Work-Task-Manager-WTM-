using DAL.DBContext;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    internal class ProjectRepository : Repository<Project>
    {
        public ProjectRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
