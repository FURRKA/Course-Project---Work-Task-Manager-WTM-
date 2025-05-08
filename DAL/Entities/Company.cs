using DAL.Interfaces;

namespace DAL.Entities
{
    public class Company : IEntity
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
        public Company() { }
        public Company( string name)
        {
            Name = name;
        }
    }
}
