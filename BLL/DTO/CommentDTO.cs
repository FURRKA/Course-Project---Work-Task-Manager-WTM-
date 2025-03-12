using BLL.Interfaces;

namespace BLL.DTO
{
    internal class CommentDTO : IDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
