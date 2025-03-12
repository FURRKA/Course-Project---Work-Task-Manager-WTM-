using BLL.Interfaces;
using DAL;

namespace BLL.DTO
{
    internal class TaskDTO : IDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Autor { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }
        public List<TagDTO> Tags { get; set; }
        public List<CommentDTO> Comments {  get; set; }
    }
}
