using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
    public class TagDTO : IDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [ValidateNever]
        public int? TaskId { get; set; }
        public int CompanyId {  get; set; }
        public bool IsApproved { get; set; } = false;
    }
}
