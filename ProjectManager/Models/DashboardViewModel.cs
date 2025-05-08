using BLL.DTO;

namespace ProjectManager.Models
{
    public class DashboardViewModel
    {
        public string ProjectTitle { get; set; }
        public List<TaskDTO> Tasks { get; set; }
        public List<CommentDTO> Comments { get; set; }
        public string NewComment { get; set; }
    }
}
