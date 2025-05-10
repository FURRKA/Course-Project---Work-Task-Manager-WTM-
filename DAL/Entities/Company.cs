using DAL.Interfaces;

namespace DAL.Entities
{
    public class Company : IEntity
    {        
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; } = new List<User>();
        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
