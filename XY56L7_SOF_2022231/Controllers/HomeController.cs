using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using XY56L7_SOF_2022231.Data;
using XY56L7_SOF_2022231.Models;
using XY56L7_SOF_2022231.Repository.Interfaces;

namespace XY56L7_SOF_2022231.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<SiteUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<HomeController> _logger;
        private readonly ICarRepository _carRepository;
        private readonly IEmailSender _emailSender;

        public HomeController(UserManager<SiteUser> userManager, RoleManager<IdentityRole> roleManager, ILogger<HomeController> logger, ICarRepository carRepository, IEmailSender emailSender)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _carRepository = carRepository;
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
            return View(_carRepository.GetAllCars());

        }
        [Authorize(Roles = "Admin")]
        public IActionResult Users()
        {
            return View(_userManager.Users);
        }

        public IActionResult Index()
        {
            return View(_carRepository.GetAllCars());
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

            var old = _carRepository.GetCarByTitleAndOwnerId(car.Title, car.OwnerId);

            if (old == null)
            {
                _carRepository.AddCar(car);

            }

            var user = await _userManager.GetUserAsync(this.User);
            await _emailSender.SendEmailAsync(user.Email, "Car has been added!", $"{car.Title} has been added");

            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public async Task<IActionResult> Privacy()
        {
            var principal = this.User;
            var user = await _userManager.GetUserAsync(principal);

            return View();
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
            _carRepository.DeleteCar(uid);

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AdminDelete(string uid)
        {
            _carRepository.DeleteCar(uid);

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}