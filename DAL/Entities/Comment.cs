using DAL.Interfaces;

namespace DAL.Entities
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public int WorkTaskId { get; set; }
        public WorkTask Task { get; set; }

        public Comment() { }
        public Comment(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
