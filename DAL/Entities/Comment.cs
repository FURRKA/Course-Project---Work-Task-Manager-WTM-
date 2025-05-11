using DAL.Interfaces;

namespace DAL.Entities
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
