using DAL.Interfaces;

namespace DAL.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<Project>? Projects { get; set; } = new List<Project>();
        public ICollection<WorkTask>? Tasks { get; set; } = new List<WorkTask>();
        public ICollection<Comment>? Comments {  get; set; } = new List<Comment>();
    }
}
