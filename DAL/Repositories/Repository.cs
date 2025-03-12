using DAL.DBContext;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    internal abstract class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private DbSet<T> _dbSet;
        private DbContext _context;

        public Repository(ApplicationDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Create(T item)
        {
            _dbSet.Add(item);
        }

        public void Update(T item)
        {
            _dbSet.Update(item);
        }

        public void Delete(T item)
        {
            _dbSet.Remove(item);
        }

        public T? Find(Func<T, bool> predicate)
        {
            return _dbSet.Find(predicate);
        }

        public IEnumerable<T> FindAll(Func<T, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}
