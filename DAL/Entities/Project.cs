using DAL.Interfaces;

namespace DAL.Entities
{
    public class Project : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<User>? Users { get; set; } = new List<User>();
        public ICollection<WorkTask>? Tasks { get; set; } = new List<WorkTask>();
        public ICollection<Tag>? Tags { get; set; } = new List<Tag>();
    }
}
