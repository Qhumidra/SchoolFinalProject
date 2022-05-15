using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vize.Data.MemoryData;
using Vize.Models;

namespace Vize.Controllers
{
    public class NewsController : Controller
    {
        private NewsData news;
        public IActionResult News(News addNews)
        {
            
            return View(addNews);
        }
        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Add(News addNews)
        {
            news = new NewsData();
            news.AddNewsData(addNews);
            return View("News",addNews);
        }
    }
}
