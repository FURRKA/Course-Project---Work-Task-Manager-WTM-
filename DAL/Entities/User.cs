using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace DAL.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public ICollection<Project>? Projects { get; set; } = new List<Project>();
        public ICollection<WorkTask>? Tasks { get; set; } = new List<WorkTask>();
        public ICollection<Comment>? Comments {  get; set; } = new List<Comment>();

        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        public User() { }
        public User(string name)
        {
            Name = name;
        }
    }
}
