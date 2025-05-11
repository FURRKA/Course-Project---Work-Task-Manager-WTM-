using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    internal class StatisticService : Service<StatisticTaskEntity, StatisticTaskDTO>, IStatisticService
    {
        public StatisticService(IRepository<StatisticTaskEntity> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public void AddDoneTask(int companyId, int projectId, DateTime date)
        {
            var statobj = Find(s => s.ProjectId == projectId &&
             s.CompanyId == companyId && s.Date == date);

            if (statobj == null)
            {
                var obj = new StatisticTaskDTO()
                {
                    CompanyId = companyId,
                    ProjectId = projectId,
                    Date = date,
                    CompleteTask = 1
                };
                Create(obj);
            }
            else
            {
                statobj.CompleteTask++;
                Update(statobj);
            }
        }

        public List<StatisticTaskDTO> ReadStatistic(int companyId, int projectId, DateTime startDate, DateTime finalDate)
        {
            return GetByCriteria(s => s.Date >= startDate && s.Date <= finalDate
            && s.CompanyId == companyId && s.ProjectId == projectId);
        }
    }
}
