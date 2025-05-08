using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    internal class TagService : Service<Tag, TagDTO>
    {
        public TagService(IRepository<Tag> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
