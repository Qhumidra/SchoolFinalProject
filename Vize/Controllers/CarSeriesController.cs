using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vize.Data.MemoryData;

namespace Vize.Controllers
{
    public class CarSeriesController : Controller
    {
        private NewsData news;
        public IActionResult CarSeries()
        {
            news = new NewsData();
            return View(news.GetAll());
        }
        public IActionResult Formula()
        {
            news = new NewsData();
            return View(news.GetAll());
        }

        public IActionResult IndyCar()
        {
            news = new NewsData();
            return View(news.GetAll());
        }
    }
}
