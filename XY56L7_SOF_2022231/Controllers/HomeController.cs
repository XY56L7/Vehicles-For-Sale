using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using XY56L7_SOF_2022231.Data;
using XY56L7_SOF_2022231.Logic.Interfaces;
using XY56L7_SOF_2022231.Models;


namespace XY56L7_SOF_2022231.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<SiteUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<HomeController> _logger;
        private readonly ICarLogic _carLogic;
        private readonly IEmailSender _emailSender;

        public HomeController(UserManager<SiteUser> userManager, RoleManager<IdentityRole> roleManager, ILogger<HomeController> logger, ICarLogic carLogic, IEmailSender emailSender)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _carLogic = carLogic;
            _emailSender = emailSender;
        }
        
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveAdmin(string uid)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);
            await _userManager.RemoveFromRoleAsync(user, "Admin");
            return RedirectToAction(nameof(Users));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GrantAdmin(string uid)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);
            await _userManager.AddToRoleAsync(user, "Admin");
            return RedirectToAction(nameof(Users));
        }
        public async Task<IActionResult> DelegateAdmin()
        {
            var principal = this.User;
            var user = await _userManager.GetUserAsync(principal);
            var role = new IdentityRole()
            {
                Name = "Admin"
            };
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(role);
            }
            await _userManager.AddToRoleAsync(user, "Admin");
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            return View(_carLogic.GetAllCars());

        }
        [Authorize(Roles = "Admin")]
        public IActionResult Users()
        {
            return View(_userManager.Users);
        }

        public IActionResult Index()
        {
            return View(_carLogic.GetAllCars());
        }
        [Authorize]
        public IActionResult Add()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(Car car)
        {
            car.OwnerId = _userManager.GetUserId(this.User);

            var old = _carLogic.GetCarByTitleAndOwnerId(car.Title, car.OwnerId);

            if (old == null)
            {
                _carLogic.AddCar(car);

            }

            var user = await _userManager.GetUserAsync(this.User);
            await _emailSender.SendEmailAsync(user.Email, "Car has been added!", $"{car.Title} has been added");

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> GetImage(string userid)
        {
            var principal = this.User;
            var user = _userManager.Users.FirstOrDefault(t => t.Id == userid);

            return new FileContentResult(user.Data, user.ContentType);
        }

        [Authorize]
        public IActionResult Delete(string uid)
        {
            var userId = _userManager.GetUserId(this.User);
            _carLogic.DeleteCar(uid);

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AdminDelete(string uid)
        {
            _carLogic.DeleteCar(uid);

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}