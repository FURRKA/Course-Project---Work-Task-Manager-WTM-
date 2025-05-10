using DAL.DBContext;

namespace DAL.Repositories
{
    internal class TaskRepository : Repository<Entities.Task>
    {
        public TaskRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
