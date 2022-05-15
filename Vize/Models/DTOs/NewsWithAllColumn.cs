using System;

namespace Vize.Models.DTOs
{
    public class NewsWithAllColumn
    {
        public int NewsId { get; set; }
        public int SerieId { get; set; }
        public string SeriesName { get; set; }
        public int RaceId { get; set; }
        public string RacesName { get; set; }
        public string NewsTitle { get; set; }
        public string NewsArticle { get; set; }
        public int ImageId { get; set; }
        public string ImgPath { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public DateTime Date { get; set; }
        
    }
}
