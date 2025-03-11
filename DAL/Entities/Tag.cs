using DAL.Interfaces;

namespace DAL.Entities
{
    public class Tag : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Project>? Projects { get; set; } = new List<Project>();
        public ICollection<WorkTask>? Tasks { get; set; } = new List<WorkTask>();
    }
}
