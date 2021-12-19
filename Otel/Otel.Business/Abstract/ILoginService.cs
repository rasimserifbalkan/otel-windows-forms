using System;
using System.Collections.Generic;
using System.Text;

namespace Otel.Business.Abstract
{
    public interface ILoginService
    {
        List<string> Login(string email,string password);
    }
}
