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
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public Status Status { get; set; } = Status.Waiting;

        [ValidateNever]
        public int ProjectId { get; set; }
        public int? UserId { get; set; }

        public List<TagDTO>? Tags { get; set; }
        public List<CommentDTO>? Comments {  get; set; }
    }
}
