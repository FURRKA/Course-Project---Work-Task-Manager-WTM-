using DAL.DBContext;
using DAL.Entities;

namespace DAL.Repositories
{
    internal class TagRepository : Repository<Tag>
    {
        public TagRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
