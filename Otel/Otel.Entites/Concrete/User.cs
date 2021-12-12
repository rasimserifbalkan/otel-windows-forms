using System;
using System.Collections.Generic;
using System.Text;
using Otel.Core.Entities;
namespace Otel.Entites.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
