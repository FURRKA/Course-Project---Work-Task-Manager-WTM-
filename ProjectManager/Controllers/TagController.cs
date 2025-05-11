using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace ProjectManager.Controllers
{
    public class TagController : Controller
    {
        private readonly IService<Tag, TagDTO> _tagService;
        private readonly IService<DAL.Entities.Task, TaskDTO> _taskService;
        private readonly IService<Project, ProjectDTO> _projectService;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private static int _companyId;
        private static TaskDTO? task;

        public TagController(IService<Tag, TagDTO> tagService, IService<DAL.Entities.Task, TaskDTO> taskService,
            IService<Project, ProjectDTO> projectService, UserManager<User> userManager, IMapper mapper)
        {
            _tagService = tagService;
            _taskService = taskService;
            _projectService = projectService;
            _userManager = userManager;
            _mapper = mapper;
        }

        public IActionResult Index(int companyId)
        {
            _companyId = companyId;

            var tags = _tagService.GetByCriteria(tag => tag.CompanyId == companyId);
            return View(tags);
        }

        [HttpGet]
        public async Task<IActionResult> Create(int companyId)
        {
            _companyId = companyId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TagDTO model)
        {
            model.CompanyId = _companyId;

            if (ModelState.IsValid)
            {
                _tagService.Create(model);
                return RedirectToAction("Index", "Tag", new { companyId = _companyId});
            }

            return View(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> Approve(int tagId)
        {
            var tag = _tagService.GetById(tagId);
            tag.IsApproved = true;
            _tagService.Update(tag);

            return RedirectToAction("Index", "Tag", new { companyId = _companyId });
        }


    }
}
