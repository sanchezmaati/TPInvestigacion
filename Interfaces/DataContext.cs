using Microsoft.EntityFrameworkCore;
using TPInvestigacion.Clases;

namespace TPInvestigacion.Interfaces
{
    public class DataContext : DbContext
    {
        public DbSet<Moto> Motos { get; set; }


        public DataContext() : base()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("DataSource=Moto.db");
            }
            
        }


        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Moto>().ToTable("Info");
            base.OnModelCreating(modelBuilder);
        }*/


    }
}
