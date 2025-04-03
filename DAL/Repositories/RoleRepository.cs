using DAL.DBContext;
using DAL.Entities;

namespace DAL.Repositories
{
    internal class RoleRepository : Repository<Role>
    {
        public RoleRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
