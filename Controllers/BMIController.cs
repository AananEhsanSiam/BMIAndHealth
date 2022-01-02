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
    public class BMIController : Controller {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDBContext _db;

        public BMIController(UserManager<IdentityUser> userManager, ApplicationDBContext db) {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index() {
            BMIVM bMIVM = new BMIVM();
            if (User.Identity.IsAuthenticated) {
                var userId = _userManager.GetUserId(User);
                var appUser = _db.ApplicationUser.Find(userId);

                var history = _db.UserHistory.Where(c => c.UserId == userId).OrderByDescending(k => k.Time).Take(5);

                bMIVM = new BMIVM() {
                    Height = appUser.Height,
                    userHistories = history
                };
            }

            return View(bMIVM);
        }

        public IActionResult BMIResult(double result) {
            return View(result);
        }

        public IActionResult ShowChart() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CalculateBMI(BMIVM bmiVM) {
            double BMIResult = BMICalculator.Calculate(bmiVM.Height, bmiVM.Weight);
            return RedirectToAction("BMIResult", new { result = BMIResult });
        }
    }
}
