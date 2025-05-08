using BLL.Interfaces;
using DAL;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO
{
    public class TaskDTO : IDTO
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [ValidateNever]
        public string Autor { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }
        public List<TagDTO>? Tags { get; set; }
        public List<CommentDTO>? Comments {  get; set; }
    }
}
