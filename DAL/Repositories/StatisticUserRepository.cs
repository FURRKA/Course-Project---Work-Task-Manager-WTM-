using DAL.DBContext;
using DAL.Entities;

namespace DAL.Repositories
{
    internal class StatisticUserRepository : Repository<StatisticUserEntity>
    {
        public StatisticUserRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
