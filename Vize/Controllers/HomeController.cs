using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vize.Data.EntityFramework;
using Vize.Data.MemoryData;
using Vize.Models;

namespace Vize.Controllers
{
    public class HomeController : Controller
    {
        EfNewsDal _newsDal = new EfNewsDal();
        public IActionResult Home()
        {
            var result = _newsDal.GetAllColumn();
            return View(result);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
