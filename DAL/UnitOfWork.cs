using DAL.DBContext;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL
{
    internal class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly ApplicationDBContext _dbContext;
        //public IRepository<User> Users { get; }
        public IRepository<Comment> Comments { get; }
        public IRepository<Tag> Tags { get; }
        public IRepository<Entities.Task> Tasks { get; }
        public IRepository<Project> Projects { get; }

        public UnitOfWork(ApplicationDBContext context, IRepository<Comment> comments,
            IRepository<Tag> tags, IRepository<Entities.Task> tasks, IRepository<Project> projects)
        {
            _dbContext = context;
            //Users = users;
            Comments = comments;
            Tags = tags;
            Tasks = tasks;
            Projects = projects;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
