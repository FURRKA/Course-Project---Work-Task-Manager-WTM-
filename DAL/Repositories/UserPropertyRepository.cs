using DAL.DBContext;
using DAL.Entities;

namespace DAL.Repositories
{
    internal class UserPropertyRepository : Repository<UserProperty>
    {
        public UserPropertyRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
