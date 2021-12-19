using Otel.Core.Entities;//use edin
using Microsoft.EntityFrameworkCore;//use edin
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace Otel.Core.DataAccess.EntityFramework
{
    //TContext bağlanılacak database
    public class EfEntityRepositoryBase<Tablo, TContext> : IEntityRepository<Tablo>
        where Tablo : class, IEntity, new()
        where TContext : DbContext, new()

    {
        public void Add(Tablo entity)
        {
            using (var context = new TContext())
            {
                var addedEntity= context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public bool Any(Expression<Func<Tablo, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<Tablo>().Any(filter);
            }
        }

        public void Delete(Tablo entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Tablo Get(Expression<Func<Tablo, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<Tablo>().FirstOrDefault(filter);
            }
        }

        public List<Tablo> List(Expression<Func<Tablo, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<Tablo>().Where(filter).ToList();
            }
        }

        public IQueryable<Tablo> Query(Expression<Func<Tablo, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<Tablo>().Where(filter).AsQueryable();
            }
        }

        public void Update(Tablo entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry<Tablo>(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
