using DAL.Interfaces;

namespace DAL.Entities
{
    public class StatisticTaskEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CompleteTask { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
