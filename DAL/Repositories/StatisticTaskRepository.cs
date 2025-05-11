using DAL.DBContext;
using DAL.Entities;

namespace DAL.Repositories
{
    internal class StatisticTaskRepository : Repository<StatisticTaskEntity>
    {
        public StatisticTaskRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
