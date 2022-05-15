using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vize.Models;

namespace Vize.Data.EntityFramework
{
    public class EfRacesDal
    {
        public Race Get(Expression<Func<Race, bool>> filter)
        {
            using (var context = new NewsDbContext())
            {
                return context.Set<Race>().SingleOrDefault(filter);
            }
        }

        public List<Race> GetAll(Expression<Func<Race, bool>> filter = null)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                return filter == null ? context.Set<Race>().ToList() : context.Set<Race>().Where(filter).ToList();
            }
        }
        public void Add(Race race)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var addedEntity = context.Entry(race);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Race race)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var deletedEntity = context.Entry(race);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Race race)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var updatedEntity = context.Entry(race);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
