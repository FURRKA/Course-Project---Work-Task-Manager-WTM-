using DAL.DBContext;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    internal class CommentRepository : Repository<Comment>
    {
        public CommentRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
