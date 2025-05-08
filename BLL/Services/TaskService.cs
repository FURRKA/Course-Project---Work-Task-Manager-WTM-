using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    internal class TaskService : Service<WorkTask, TaskDTO>, ITaskService
    {
        public TaskService(IRepository<WorkTask> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
