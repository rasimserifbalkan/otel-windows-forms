using Microsoft.EntityFrameworkCore; // use edilecek
using Otel.Entites.Concrete;

namespace Otel.DataAccess.Concrete.EntityFramework
{
    public class OtelContext : DbContext
    {
        //Onconfiguring isimli methoduda override etmeli ve kendi kodlarınızı yazmalısınız DBContext sizin dbniz için konfigure edilmelidir.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=185.242.162.113;Initial Catalog=db1_otel;User ID=db1_otel;Password=Abc123@@");
        }
        public DbSet<User> Users { get; set; }
    }
}
