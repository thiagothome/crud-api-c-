using Crud2.Estudantes;
using Microsoft.EntityFrameworkCore;

namespace Crud2.Data
{
    public class CrudContext : DbContext
    {

        public DbSet<Estudante> Estudantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-N76CAM8D;Database=Db_Estudantes;User Id=sa;Password=2020005447;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
