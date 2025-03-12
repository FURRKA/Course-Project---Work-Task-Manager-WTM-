using DAL.DBContext;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    internal class TaskRepository : Repository<WorkTask>
    {
        public TaskRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
