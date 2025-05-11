using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    internal class ProjectService : Service<Project, ProjectDTO>
    {
        public ProjectService(IRepository<Project> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
