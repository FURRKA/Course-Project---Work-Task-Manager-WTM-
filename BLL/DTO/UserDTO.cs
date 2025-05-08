using BLL.Interfaces;

namespace BLL.DTO
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public List<ProjectDTO> Projects { get; set; }
        public List<TaskDTO> Tasks { get; set; }
    }
}
