using DAL.DBContext;
using DAL.Entities;

namespace DAL.Repositories
{
    internal class CompanyRepository : Repository<Company>
    {
        public CompanyRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
