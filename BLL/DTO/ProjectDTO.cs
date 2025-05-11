using BLL.Interfaces;
using DAL;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
    public class ProjectDTO : IDTO
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [ValidateNever]
        public int CompanyId { get; set; }
        public List<TaskDTO>? Tasks { get; set; }
    }
}
