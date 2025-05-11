using DAL.Interfaces;

namespace DAL.Entities
{
    public class Tag : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Task>? Tasks { get; set; } = new List<Task>();
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public bool IsApproved { get; set; }
    }
}
