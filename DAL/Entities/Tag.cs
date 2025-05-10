using DAL.Interfaces;

namespace DAL.Entities
{
    public class Tag : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }
    }
}
