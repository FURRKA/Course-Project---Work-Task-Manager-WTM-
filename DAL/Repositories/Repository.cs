﻿using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private DbSet<T> _dbSet;
        private DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Create(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public void Delete(T item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
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

        public void Update(T item)
        {
            _dbSet.Update(item);
            _context.SaveChanges();
        }
    }
}
