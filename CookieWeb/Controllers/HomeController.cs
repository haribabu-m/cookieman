using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using InternationalCookies.Models;

namespace CookieWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _appsettings;
        public HomeController(IOptions<AppSettings> appsettings)
        {
            _appsettings = appsettings.Value;
        }
        public IActionResult Index()
        {
            string region = _appsettings.Region;

            ViewData.Add("Region", region);
            ViewBag.RegionMine = region;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
