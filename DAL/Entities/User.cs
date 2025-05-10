using Microsoft.AspNetCore.Identity;

namespace DAL.Entities
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }
        public int? CompanyId { get; set; }
        public virtual Company? Company { get; set; }
        public virtual ICollection<Task>? Tasks { get; set; } = new List<Task>();
    }
}
