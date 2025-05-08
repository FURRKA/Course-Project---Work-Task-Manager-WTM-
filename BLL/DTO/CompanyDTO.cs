using BLL.Interfaces;

namespace BLL.DTO
{
    public class CompanyDTO : IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserDTO> Users { get; set; } = new List<UserDTO>();

        public CompanyDTO() { }

        public CompanyDTO(string name, List<UserDTO> users)
        {
            Name = name;
            Users = users;
        }
    }
}
