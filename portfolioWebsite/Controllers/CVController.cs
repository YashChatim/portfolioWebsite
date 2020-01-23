using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace portfolioWebsite.Controllers
{
    public class CVController : Controller
    {
        public IActionResult CV()
        {
            return View();
        }
    }
}