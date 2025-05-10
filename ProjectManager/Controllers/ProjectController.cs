using AutoMapper;
using BLL;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            var projects = _projectService.GetByCriteria(p => p.CompanyId == user.CompanyId);
            //_projectService.GetByCriteria(p => user.Companys.Any(c => c.Projects.Select(po => po.Id).Contains(p.Id)));
            return View(projects);
        }

        [HttpGet]
        public IActionResult GetTasksByProject(int projectId)
        {
            var tasks = _projectService.GetById(projectId).Tasks;
            return PartialView("_TaskListPartial", tasks);
        }

        [HttpGet]
        public async Task<IActionResult> CreateAsync()
        {
            var tags = _tagService.GetAll();
            ViewBag.Tags = tags;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProjectDTO project)
        {
            var user = await _userManager.GetUserAsync(User);
            project.Description = " 123";
            project.CompanyId = (int)user.CompanyId;

            if (!ModelState.IsValid)
            {
                ModelState.Log();

                ViewBag.Tags = _tagService.GetAll();
                return View(project);
            }

            _projectService.Create(project);

            return RedirectToAction("Index");
        }
    }
}
