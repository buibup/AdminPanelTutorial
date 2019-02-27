using AdminPanelTutorial.Models;
using AdminPanelTutorial.ViewModels;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminPanelTutorial.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            DashboardViewModel dashboard = new DashboardViewModel();

            dashboard.doctors_count = db.Doctors.Count();
            dashboard.nurses_count = db.Nurses.Count();
            dashboard.patients_count = db.Patients.Count();
            return View(dashboard);
        }
    }
}