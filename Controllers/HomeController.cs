using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Registration.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            var registrationForm = _context.RegistrationForm.ToList();

            return View(registrationForm);
        }

        public IActionResult NewRegistration(string GivenName, string FamilyName, string Gender, string Country, DateTime RegistrationDate)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.GivenName = GivenName;
            rf.FamilyName = FamilyName;
            rf.Gender = Gender;
            rf.Country = Country;
            rf.RegistrationDate = RegistrationDate;
            _context.RegistrationForm.Add(rf);
            _context.SaveChanges();
        return RedirectToAction("Index");
        }

    }
}
