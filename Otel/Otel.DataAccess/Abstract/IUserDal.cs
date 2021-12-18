using System;
using System.Collections.Generic;
using System.Text;
using Otel.Core.DataAccess;
using Otel.Entites.Concrete;

namespace Otel.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User> 
    {

    }
}
