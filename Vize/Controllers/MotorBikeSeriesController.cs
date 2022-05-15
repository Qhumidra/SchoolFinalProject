using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vize.Data.MemoryData;

namespace Vize.Controllers
{
    public class MotorBikeSeriesController : Controller
    {
        private NewsData news;
        public IActionResult MotorBikeSeries()
        {
            news = new NewsData();
            return View(news.GetAll());
        }
        public IActionResult MotoGp()
        {
            news = new NewsData();
            return View(news.GetAll());
        }
        
        public IActionResult WorldSuperbike()
        {
            news = new NewsData();
            return View(news.GetAll());
        }
    }
}
