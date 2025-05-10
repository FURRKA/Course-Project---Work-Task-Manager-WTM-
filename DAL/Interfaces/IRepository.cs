namespace DAL.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        public IEnumerable<T> GetAll();
        public IEnumerable<T> FindAll(Func<T, bool> predicate);
        public T? GetById(int id);
        public T? Find(Func<T, bool> predicate);
        public void Create(T item);
        public void Update(T item);
        public void Delete(T item);
    }
}
