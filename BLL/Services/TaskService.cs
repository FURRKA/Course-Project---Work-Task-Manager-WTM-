using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    internal class TaskService : Service<DAL.Entities.Task, TaskDTO>
    {
        public TaskService(IRepository<DAL.Entities.Task> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
