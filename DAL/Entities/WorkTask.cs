using DAL.Interfaces;

namespace DAL.Entities
{
    public class WorkTask : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Autor {  get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Status Status { get; set; } = Status.Waiting;

        public ICollection<User>? Users { get; set; } = new List<User>();
        public ICollection<Project> Projects { get; set; } = new List<Project>();
        public ICollection<Comment>? Comments { get; set; } = new List<Comment>();
        public ICollection<Tag>? Tags { get; set; } = new List<Tag>();
    }
}
