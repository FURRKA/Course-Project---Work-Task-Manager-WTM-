using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    internal class CompanyService : Service<Company, CompanyDTO>
    {
        public CompanyService(IRepository<Company> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
