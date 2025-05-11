using BLL.DTO;
using DAL;
using Microsoft.AspNetCore.Mvc;
using ProjectManager.Models;
using System.Diagnostics;

namespace ProjectManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        //public async Task<IActionResult> GetComments(int id)
        //{
        //    var task = new TaskDTO
        //    {
        //        Id = 1,
        //        Title = "������ ������",
        //        Description = "�������� ������",
        //        Autor = "�����",
        //        Date = DateTime.Now,
        //        Status = Status.InProcess,
        //        Tags = new List<TagDTO>(),
        //        Comments = new List<CommentDTO>
        //            {
        //                new CommentDTO
        //                {
        //                    Id = 1,
        //                    Description = "����������� 1",
        //                    User = new UserDTO { Name = "������������ A" }
        //                },
        //                new CommentDTO
        //                {
        //                    Id = 2,
        //                    Description = "����������� 2",
        //                    User = new UserDTO { Name = "������������ �" }
        //                }
        //            }
        //    };
        //    if (task == null) return NotFound();

        //    return PartialView("_CommentsPartial", task.Comments);
        //}

        //[HttpPost]
        //public async Task<IActionResult> AddComment([FromBody] CommentRequestModel model)
        //{
        //    // ����� �� ������ �������� ������ �� �� � �������� �����������
        //    // ���� ������ ��������:

        //    var comments = new List<CommentDTO>
        //    {
        //        new CommentDTO
        //        {
        //            Id = 1,
        //            Description = model.Description,
        //            User = new UserDTO { Name = "��" } // ��� �������� �� ���������
        //        }
        //    };

        //    return PartialView("_CommentsPartial", comments);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
