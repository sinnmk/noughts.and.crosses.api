using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Client.Models;

namespace Client.Controllers
{
    public class MainController : ControllerBase
    {
        public IActionResult Index()
        {
            var sessionData = new SessionData
            {
                ServiceUser = ServiceUser
            };

            return View(sessionData);
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
