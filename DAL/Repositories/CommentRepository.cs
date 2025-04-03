using DAL.DBContext;
using DAL.Entities;

namespace DAL.Repositories
{
    internal class CommentRepository : Repository<Comment>
    {
        public CommentRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
