using BLL.Interfaces;

namespace BLL.DTO
{
    public class UserDTO : IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CompanyDTO? Company { get; set; }
        public List<TaskDTO>? Tasks { get; set; }
    }
}
