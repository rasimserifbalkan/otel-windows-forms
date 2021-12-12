using Otel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
namespace Otel.Core.DataAccess.EntityFramework
{
    public interface IEfEntityRepositoryBase<Tablo> where Tablo: class, IEntity , new()
    {
        Tablo Get(Expression<Func<Tablo, bool>> filter = null);
        List<Tablo> List(Expression<Func<Tablo, bool>> filter = null);
        IQueryable<Tablo> Query(Expression<Func<Tablo, bool>> filter = null);
        void Add(Tablo entity);
        void Update(Tablo entity);
        void Delete(Tablo entity);
    }
}
