using BMIAndHealth.Data;
using BMIAndHealth.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMIAndHealth.Controllers {
    public class ResultController : Controller {
        private readonly ApplicationDBContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        public ResultController(ApplicationDBContext db, UserManager<IdentityUser> userManager) {
            _db = db;
            _userManager = userManager;

        }

        public IActionResult SaveBMIHistory(double? id) {
            if (id != null && id != 0) {
                string userId = _userManager.GetUserId(User);
                UserHistory userHistory = new UserHistory() {
                    UserId = userId,
                    BMI = id.Value,
                    Time = DateTime.Now
                };

                _db.UserHistory.Add(userHistory);
                _db.SaveChanges();
            }

            return RedirectToAction("Index","BMI");
        }
    }
}
