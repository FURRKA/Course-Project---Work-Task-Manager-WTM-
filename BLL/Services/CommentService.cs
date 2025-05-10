using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    internal class CommentService : Service<Comment, CommentDTO>
    {
        public CommentService(IRepository<Comment> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
