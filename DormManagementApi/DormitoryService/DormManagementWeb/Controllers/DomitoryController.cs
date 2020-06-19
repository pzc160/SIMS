using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DormManagementWeb.Controllers
{
    public class DomitoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}