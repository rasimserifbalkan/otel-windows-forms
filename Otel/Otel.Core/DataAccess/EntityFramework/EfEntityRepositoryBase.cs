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
        where TContext : class, DbContext, new()

    {
        public void Add(Tablo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tablo entity)
        {
            throw new NotImplementedException();
        }

        public Tablo Get(Expression<Func<Tablo, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Tablo> List(Expression<Func<Tablo, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Tablo> Query(Expression<Func<Tablo, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Tablo entity)
        {
            throw new NotImplementedException();
        }
    }
}
