using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BenjaminCamacho.Models;
using BenjaminCamacho.Services;
using Microsoft.AspNetCore.Authorization;

namespace BenjaminCamacho.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployyeService employyeService;

        public HomeController(ILogger<HomeController> logger, IEmployyeService employyeService)
        {
            _logger = logger;
            this.employyeService = employyeService;
        }

        public IActionResult Index()
        {
            var empleados = employyeService.GetAll();
            return View(empleados);
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Terms()
        {
            return View();
        }

        public IActionResult Charts()
        {
            return View();
        }

        public IActionResult Tables()
        {
            var empleados = employyeService.GetAll();
            return View(empleados);
        }

        public IActionResult _401()
        {
            return View();
        }

        public IActionResult _404()
        {
            return View();
        }

        public IActionResult _500()
        {
            return View();
        }

        public IActionResult LayoutStatic()
        {
            return View();
        }

        public IActionResult SidenavLight()
        {
            return View();
        }


        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
