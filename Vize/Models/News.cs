using System;

namespace Vize.Models
{
    public class News
    {
        public int NewsId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsArticle { get; set; }
        public DateTime Date { get; set; }
        public Serie Serie { get; set; }
        public Image Image { get; set; }
    }
}
