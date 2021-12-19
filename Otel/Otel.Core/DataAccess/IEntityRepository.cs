using Otel.Core.Entities;//IEntity için
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace Otel.Core.DataAccess
{
    //IEntityRepository aslında db deki tablolarda işlem yapmak için kullanacağımız methodları temsil eder.
    //Ama temsil edeceği tablolar birbirinden çok farklı olduğundan her seferinde her tablo için bir interface yazamayız onun yerine IEntityRepository generik olarak her tablo için şekillenecek biçimde ayarlanabilir.
    //<Tablo> aslında bu interface nin alacağı şekildir.Yani Tablo yerine herşey yazılabilir herşey derken kurallara uymalıdır.
    public interface IEntityRepository<Tablo> where Tablo : class, IEntity, new()
    {
        Tablo Get(Expression<Func<Tablo, bool>> filter = null);
        List<Tablo> List(Expression<Func<Tablo, bool>> filter = null);
        IQueryable<Tablo> Query(Expression<Func<Tablo, bool>> filter = null);
        void Add(Tablo entity);
        void Update(Tablo entity);
        void Delete(Tablo entity);

        bool Any(Expression<Func<Tablo, bool>> filter);

    }
}
