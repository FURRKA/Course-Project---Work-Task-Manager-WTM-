using BLL.DTO;

namespace BLL.Interfaces
{
    public interface ICompanyService
    {
        public void CreateWithUser(CompanyDTO company, UserDTO user);
    }
}
