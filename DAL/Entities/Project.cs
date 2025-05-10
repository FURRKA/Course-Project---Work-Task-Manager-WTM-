using DAL.Interfaces;

namespace DAL.Entities
{
    public class Project : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Task>? Tasks { get; set; } = new List<Task>();
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

    }
}
