using AutoMapper;
using BLL;
using BLL.DTO;
using BLL.Interfaces;
using DAL;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectManager.Models;

namespace ProjectManager.Controllers
{
    public class TaskController : Controller
    {
        private readonly IService<DAL.Entities.Task, TaskDTO> _taskService;
        private readonly IService<Project, ProjectDTO> _projectService;
        private readonly UserManager<User> _userManager;
        private readonly IService<Comment,  CommentDTO> _commentService;
        private readonly IMapper _mapper;
        private static int currentId = 1;
        private static ProjectDTO project;

        public TaskController(IService<DAL.Entities.Task, TaskDTO> taskService, IService<Project, ProjectDTO> projectService,
            IService<Comment, CommentDTO> commentService, UserManager<User> user, IMapper mapper)
        {
            _taskService = taskService;
            _projectService = projectService;
            _userManager = user;
            _mapper = mapper;
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult TaskList(int projectId)
        {
            project = _projectService.Find(p => p.Id == projectId);
            if (project == null)
                return NotFound();

            currentId = projectId;

            var viewModel = new DashboardViewModel
            {
                ProjectTitle = project.Title,
                Tasks = project.Tasks
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> MyTasks()
        {
            var user = await _userManager.GetUserAsync(User);
            var tasks = _taskService.GetAll().Where(t => t.UserId == user.Id).ToList();
            return View(tasks);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TaskDTO task)
        {
            var user = await _userManager.GetUserAsync(User);
            task.Autor = user.Name;

            if (!ModelState.IsValid)
            {
                ModelState.Log();
                return View(task);
            }

            task.ProjectId = currentId;

            _taskService.Create(task);
            //project.Tasks.Add(task);
            //_projectService.Update(project);

            return RedirectToAction("TaskList", "Task", new { projectId = currentId });
        }

        [HttpPost]
        public async Task<IActionResult> Add(int taskId)
        {
            var task = _taskService.GetById(taskId);
            var user = await _userManager.GetUserAsync(User);

            task.UserId = user.Id;
            task.Status = Status.InProcess;
            _taskService.Update(task);

            return RedirectToAction("TaskList", "Task", new { projectId = currentId });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int taskId)
        {
            _taskService.Delete(taskId);

            return RedirectToAction("TaskList", "Task", new { projectId = currentId });
        }

        [HttpPost]
        public async Task<IActionResult> Complete(int taskId)
        {
            var task = _taskService.GetById(taskId);
            task.Status = Status.Done;
            task.UserId = null;
            _taskService.Update(task);

            return RedirectToAction("MyTasks");
        }

        [HttpPost]
        public async Task<IActionResult> Unassign(int taskId)
        {
            var task = _taskService.GetById(taskId);
            task.Status = Status.Waiting;
            task.UserId = null;
            _taskService.Update(task);

            return RedirectToAction("MyTasks");
        }

        [HttpGet]
        public async Task<IActionResult> GetComments(int id)
        {
            var task = _taskService.GetById(id);
            if (task == null) return NotFound();

            return PartialView("_CommentsPartial", task.Comments);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment([FromBody] CommentRequestModel model)
        {
            var task = _taskService.GetById(model.TaskId);
            var comments = task.Comments;
            var user = await _userManager.GetUserAsync(User);

            if (model == null) return NotFound();

            var newComment = new CommentDTO()
            {
                Description = model.Description,
                User = new UserDTO() { Name = user.Name},
                TaskId = task.Id              
            };

            _commentService.Create(newComment);
            comments.Add(newComment);

            return PartialView("_CommentsPartial", comments);
        }
    }
}
