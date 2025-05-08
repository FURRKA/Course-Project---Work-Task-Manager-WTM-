using BLL.Interfaces;

namespace BLL.DTO
{
    public class CommentDTO : IDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public UserDTO User { get; set; }
    }
}
