using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using XY56L7_SOF_2022231.Logic.Interfaces;
using XY56L7_SOF_2022231.Models;


namespace XY56L7_SOF_2022231.Controllers
{
    public class MotorCycleController : Controller
    {
        private readonly IMotorcycleLogic _motorcycleLogic;
        private readonly UserManager<SiteUser> _userManager;
        private readonly IEmailSender _emailSender;

        public MotorCycleController(IMotorcycleLogic motorcycleLogic, UserManager<SiteUser> userManager, IEmailSender emailSender)
        {
            _motorcycleLogic = motorcycleLogic;
            _userManager = userManager;
            _emailSender = emailSender;
        }

        [Authorize]
        public IActionResult Index_MotorCycle()
        {
            return View(_motorcycleLogic.GetAllMotorcycles());
        }

        [Authorize]
        public IActionResult Add_MotorCycle()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(Motorcycle motorcycle)
        {
            motorcycle.OwnerId = _userManager.GetUserId(this.User);

            var old = _motorcycleLogic.GetMotorcycleByTitleAndOwnerId(motorcycle.Title, motorcycle.OwnerId);

            if (old == null)
            {
                _motorcycleLogic.AddMotorcycle(motorcycle);
            }

            var user = await _userManager.GetUserAsync(this.User);
            await _emailSender.SendEmailAsync(user.Email, "Motorcycle has been added!", $"{motorcycle.Title} has been added");

            return RedirectToAction(nameof(Index_MotorCycle));
        }

        [Authorize]
        public IActionResult Delete(string uid)
        {
            var userId = _userManager.GetUserId(this.User);
            _motorcycleLogic.DeleteMotorcycle(uid);

            return RedirectToAction(nameof(Index_MotorCycle));
        }
    }
}
