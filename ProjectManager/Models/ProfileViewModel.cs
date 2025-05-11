using DAL.Entities;

namespace ProjectManager.Models
{
    public class ProfileViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<string> Role { get; set; }
        public Company? Company { get; set; }

        public bool IsCompanyAttached => Company != null;
    }
}
