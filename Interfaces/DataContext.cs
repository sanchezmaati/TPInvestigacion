using Microsoft.EntityFrameworkCore;
using TPInvestigacion.Clases;

namespace TPInvestigacion.Interfaces
{
    public class DataContext : DbContext
    {

        public DataContext() : base()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }



        public virtual DbSet<Moto> Motos { get; set; }
    }
}
