using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vize.Models;

namespace Vize.Data.EntityFramework
{
    public class EfSeriesDal
    {
        public Serie Get(Expression<Func<Serie, bool>> filter)
        {
            using (var context = new NewsDbContext())
            {
                return context.Set<Serie>().SingleOrDefault(filter);
            }
        }

        public List<Serie> GetAll(Expression<Func<Serie, bool>> filter = null)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                return filter == null ? context.Set<Serie>().ToList() : context.Set<Serie>().Where(filter).ToList();
            }
        }
        public void Add(Serie serie)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var addedEntity = context.Entry(serie);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Serie serie)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var deletedEntity = context.Entry(serie);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Serie serie)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var updatedEntity = context.Entry(serie);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
