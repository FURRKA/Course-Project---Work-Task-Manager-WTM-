using AutoMapper;
using BLL;
using BLL.DTO;
using BLL.Interfaces;
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
        private readonly IMapper _mapper;
        private static int currentId = 1;
        private static ProjectDTO project;

        public TaskController(IService<DAL.Entities.Task, TaskDTO> taskService, IService<Project, ProjectDTO> projectService, UserManager<User> user, IMapper mapper)
        {
            _taskService = taskService;
            _projectService = projectService;
            _userManager = user;
            _mapper = mapper;
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

            return View();
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
            project.Tasks.Add(task);
            _projectService.Update(project);

            return RedirectToAction("TaskList", "Task", new { projectId = currentId });
        }

        [HttpPost]
        public async Task<IActionResult> Add(int taskId)
        {
            var task = _taskService.GetById(taskId);
            var user = await _userManager.GetUserAsync(User);

            task.UserId = user.Id;
            task.Status = DAL.Status.InProcess;
            _taskService.Update(task);

            return RedirectToAction("TaskList", "Task", new { projectId = currentId });
        }
    }
}
