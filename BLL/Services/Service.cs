using AutoMapper;
using BLL.Interfaces;
using DAL.Interfaces;

namespace BLL.Services
{
    public abstract class Service<TEntity, TDTO> : IService<TEntity, TDTO>
        where TDTO : class, new() 
        where TEntity : class, new()
    {
        private readonly IRepository<TEntity> repository;
        private readonly IMapper mapper;

        protected Service(IRepository<TEntity> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void Create(TDTO item)
        {
            repository.Create(mapper.Map<TEntity>(item));
        }

        public void Delete(int id)
        {
            var obj = repository.GetById(id);
            repository.Delete(obj);
        }

        public TDTO? Find(Func<TEntity, bool> predicate)
        {
            return mapper.Map<TDTO>(repository.Find(predicate));
        }

        public List<TDTO> GetAll()
        {
            return mapper.Map<List<TDTO>>(repository.GetAll());
        }

        public List<TDTO> GetByCriteria(Func<TEntity, bool> predicate)
        {
            return mapper.Map<List<TDTO>>(repository.FindAll(predicate));
        }

        public TDTO? GetById(int id)
        {
            return mapper.Map<TDTO>(repository.GetById(id));
        }

        public void Update(int id)
        {
            repository.Update(repository.GetById(id));
        }
    }
}
