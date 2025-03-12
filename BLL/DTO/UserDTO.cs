using BLL.Interfaces;

namespace BLL.DTO
{
    internal class UserDTO : IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public List<ProjectDTO> Projects { get; set; }
        public List<TaskDTO> Tasks { get; set; }
    }
}
