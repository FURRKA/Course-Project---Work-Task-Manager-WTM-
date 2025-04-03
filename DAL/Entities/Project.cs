using DAL.Interfaces;

namespace DAL.Entities
{
    public class Project : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<UserProperty>? Users { get; set; } = new List<UserProperty>();
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<WorkTask>? Tasks { get; set; } = new List<WorkTask>();
        public ICollection<Tag>? Tags { get; set; } = new List<Tag>();
        public Project() { }
        public Project(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
