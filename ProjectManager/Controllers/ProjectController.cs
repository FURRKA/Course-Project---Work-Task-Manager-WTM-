using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ProjectManager.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IService<Project, ProjectDTO> _projectService;
        private readonly IService<Tag, TagDTO> _tagService;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public ProjectController(IService<Project, ProjectDTO> projectService, IService<Tag, TagDTO> tagService, UserManager<User> userManager, IMapper mapper)
        {
            _projectService = projectService;
            _tagService = tagService;
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var projects = _projectService.GetAll();
            return View(projects);
        }

        [HttpGet]
        public IActionResult GetTasksByProject(int projectId)
        {
            var tasks = _projectService.GetById(projectId).Tasks;
            return PartialView("_TaskListPartial", tasks);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var tags = _tagService.GetAll();
            ViewBag.Tags = tags;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProjectDTO project)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Tags = _tagService.GetAll();
                return View(project);
            }

            var user = await _userManager.GetUserAsync(User);

            project.CompanyId = (int)user.CompanyId;
            project.Company = _mapper.Map<CompanyDTO>(user.Company);
            _projectService.Create(project);

            return RedirectToAction($"TaskList/{project.Id}", "Task");
        }
    }
}
