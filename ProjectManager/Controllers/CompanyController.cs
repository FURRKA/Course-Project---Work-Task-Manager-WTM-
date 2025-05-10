using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjectManager.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IService<Company, CompanyDTO> _companyService;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public CompanyController(IService<Company, CompanyDTO> companyService, UserManager<User> userManager, IMapper mapper)
        {
            _companyService = companyService;
            _userManager = userManager;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CompanyDTO company)
        {
            if (!ModelState.IsValid)
            {
                return View(company);
            }

            var user = await _userManager.GetUserAsync(User);
            var userDTO = _mapper.Map<UserDTO>(user);

            _companyService.Create(company);
            user.Company = _mapper.Map<Company>(company);
            await _userManager.UpdateAsync(user);
            
            return RedirectToAction("Index");
        }
    }
}
