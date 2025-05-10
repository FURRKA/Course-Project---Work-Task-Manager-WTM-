using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
    public class CompanyDTO : IDTO
    {
        public int Id { get; set; }
        [Required] 
        public string Name { get; set; }

        [ValidateNever]
        public ICollection<UserDTO>? Users { get; set; } = new List<UserDTO>();
        public ICollection<ProjectDTO>? Projects { get; set; } = new List<ProjectDTO>();
    }
}
