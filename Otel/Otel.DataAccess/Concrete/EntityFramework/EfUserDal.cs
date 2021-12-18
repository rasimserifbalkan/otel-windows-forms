using System;
using System.Collections.Generic;
using System.Text;
using Otel.Core.DataAccess.EntityFramework; // use
using Otel.DataAccess.Abstract; // use
using Otel.Entites.Concrete; // use

namespace Otel.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User,OtelContext>, IUserDal
    {
    }
}
