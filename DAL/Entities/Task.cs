using DAL.Interfaces;

namespace DAL.Entities
{
    public class Task : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Autor {  get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Status Status { get; set; } = Status.Waiting;

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public int? UserId { get; set; }
        public virtual User? User { get; set; }

        public virtual ICollection<Comment>? Comments { get; set; } = new List<Comment>();
        public virtual ICollection<Tag>? Tags { get; set; } = new List<Tag>();
    }
}
