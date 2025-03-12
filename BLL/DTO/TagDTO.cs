using BLL.Interfaces;

namespace BLL.DTO
{
    public class TagDTO : IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
