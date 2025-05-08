using BLL.DTO;

namespace BLL.Interfaces
{
    public interface IService<TEntity, TDTO>
    {
        public void Create(TDTO item);
        public void Update(int id);
        public void Delete(int id);
        public TDTO? GetById(int id);
        public TDTO? Find(Func<TEntity, bool> predicate);
        public List<TDTO> GetAll();
        public List<TDTO> GetByCriteria(Func<TEntity, bool> predicate);
    }
}
