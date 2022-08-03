using Aps_task7_models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aps_task7_models.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Data data)
        {
            Debug.Print("Data inside class " + data.First + " " + data.Second + " " + data.Count);
            return View();
        }
    }
}
