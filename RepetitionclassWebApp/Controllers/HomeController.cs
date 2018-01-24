using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using RepetitionclassWebApp.Interfaces;
using RepetitionclassWebApp.Models;
using RepetitionclassWebApp.Resources;

namespace RepetitionclassWebApp.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IStringLocalizer localizer;
        
        private ITimeProvider timeProvider;
        public HomeController(ITimeProvider _timeProvider, IStringLocalizerFactory factory)
        {
            
            localizer = factory.Create(typeof(SharedResources));
            timeProvider = _timeProvider;

        }
        public IActionResult Index()
        {
            ViewData["Time"] = timeProvider.Now.ToString();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
    
        public IActionResult Contact()
        {
            ViewData["Message"] = localizer["ContactUs"];

            return View();
        }
        public IActionResult IncreaseMonth()
        {
            timeProvider.Now = timeProvider.Now.AddMonths(1);
            return View("Index");
        }
        public IActionResult DecreaseMonth()
        {
            timeProvider.Now = timeProvider.Now.AddMonths(-1);
            return View("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
