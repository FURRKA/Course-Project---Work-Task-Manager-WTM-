using DAL.Interfaces;

namespace DAL.Entities
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role() { }
        public Role (int id, string name)
        {
            Id = id;
            Name = name;
        }   
    }
}
