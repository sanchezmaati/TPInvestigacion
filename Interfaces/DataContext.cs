using Microsoft.EntityFrameworkCore;
using TPInvestigacion.Clases;

namespace TPInvestigacion.Interfaces
{
    public class DataContext : DbContext
    {
<<<<<<< HEAD
        public DbSet<Moto> Motos { get; set; }

=======
>>>>>>> 992711a201efb1dd16c1b07ed23265a48fccd662

        public DataContext() : base()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

<<<<<<< HEAD
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


=======


        public virtual DbSet<Moto> Motos { get; set; }
>>>>>>> 992711a201efb1dd16c1b07ed23265a48fccd662
    }
}
