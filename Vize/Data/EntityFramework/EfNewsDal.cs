using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vize.Models;
using Vize.Models.DTOs;

namespace Vize.Data.EntityFramework
{
    public class EfNewsDal
    {
        public News Get(Expression<Func<News, bool>> filter)
        {
            using (var context = new NewsDbContext())
            {
                return context.Set<News>().SingleOrDefault(filter);
            }
        }

        public List<News> GetAll()
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                return context.Set<News>().ToList();
            }
        }
        public void Add(News news)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var addedEntity = context.Entry(news);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(News news)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var deletedEntity = context.Entry(news);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(News news)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var updatedEntity = context.Entry(news);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<NewsWithAllColumn> GetAllColumn()
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                return context.Set<NewsWithAllColumn>().ToList();
            }
        }

    }
}
