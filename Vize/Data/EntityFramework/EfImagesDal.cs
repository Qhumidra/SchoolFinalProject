using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Vize.Models;

namespace Vize.Data.EntityFramework
{
    public class EfImagesDal
    {
        public Image Get(Expression<Func<Image, bool>> filter)
        {
            using (var context = new NewsDbContext())
            {
                return context.Set<Image>().SingleOrDefault(filter);
            }
        }

        public List<Image> GetAll(Expression<Func<Image, bool>> filter = null)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                return filter == null ? context.Set<Image>().ToList() : context.Set<Image>().Where(filter).ToList();
            }
        }
        public void Add(Image image)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var addedEntity = context.Entry(image);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Image image)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var deletedEntity = context.Entry(image);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Image image)
        {
            using (NewsDbContext context = new NewsDbContext())
            {
                var updatedEntity = context.Entry(image);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
