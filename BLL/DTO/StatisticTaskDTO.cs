using BLL.Interfaces;

namespace BLL.DTO
{
    public class StatisticTaskDTO : IDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CompleteTask { get; set; }
        public int CompanyId { get; set; }
        public int ProjectId { get; set; }
    }
}
