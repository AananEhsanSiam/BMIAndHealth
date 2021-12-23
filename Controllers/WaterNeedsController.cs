using BMIAndHealth.Calculators;
using BMIAndHealth.Data;
using BMIAndHealth.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMIAndHealth.Controllers {
    public class WaterNeedsController : Controller {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDBContext _db;

        public WaterNeedsController (UserManager<IdentityUser> userManager, ApplicationDBContext db) {
            _userManager = userManager;
            _db = db;
        }

        public object WNCalculator { get; private set; }

        public IActionResult Index() {
            WNVM wnvm = new WNVM();
            if (User.Identity.IsAuthenticated) {
                var userId = _userManager.GetUserId(User);
                var appUser = _db.ApplicationUser.Find(userId);

                var age = WaterNeedsCalculator.GetAge(appUser.DOB);

                wnvm = new WNVM() {
                    Age = age
                };

            }
            return View(wnvm);
        }

        public IActionResult WNResult(double result) {
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CalculateWN(WNVM wnvm) {
            double WNResult = WaterNeedsCalculator.Calculate(wnvm.Age, wnvm.Weight);
            return RedirectToAction("WNResult", new { result = WNResult });
        }
        
    }
}
