using BLL.Interfaces;
using DAL;

namespace BLL.DTO
{
    internal class ProjectDTO : IDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<TaskDTO> Tasks { get; set; }
        public List<TagDTO> Tags { get; set; }
    }
}
