using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<User> Users {  get; }
        IRepository<Comment> Comments { get; }
        IRepository<Tag> Tags { get; }
        IRepository<WorkTask> Tasks { get; }
        IRepository<Project> Projects { get; }

        public void Save();
    }
}
