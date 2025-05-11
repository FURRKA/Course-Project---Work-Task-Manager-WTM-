using BLL.DTO;

namespace BLL.Interfaces
{
    public interface IStatisticService
    {
        public void AddDoneTask(int companyId, int ProjectId, DateTime date);
        public List<StatisticTaskDTO> ReadStatistic(int companyId, int projectId, DateTime startDate, DateTime finalDate);
    }
}
