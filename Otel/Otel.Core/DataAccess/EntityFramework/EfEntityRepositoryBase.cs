using System;
using System.Collections.Generic;
using System.Text;

namespace Otel.Core.DataAccess.EntityFramework
{
    //TContext bağlanılacak database
    public class EfEntityRepositoryBase<Tablo,TContext> : IEntityRepository<Tablo>
    {
    }
}
