using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace portfolioWebsite.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult AboutMe()
        {
            return View();
        }
    }
}