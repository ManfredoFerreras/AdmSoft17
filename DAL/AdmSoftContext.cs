using AdmSoft.Models;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace AdmSoft.DAL
{
   public class AdmSoftContext :DbContext
    {
       public AdmSoftContext()
           : base("AdmSoftContext") 
    {
       // Database.SetInitializer<AdmSoftContext>(new DBInitializer());
      
    }

       public DbSet<Aptos> Aptos { set; get; }
       public DbSet<Recibos> Recibos { set; get; }
       public DbSet<Pagos> Pagos { set; get; }
       public DbSet<PagosRecibos> PagosRecibos { set; get; }
       public DbSet<Secuencia> Secuencia { set; get; }

       public DbSet<Cuadre> Cuadre { set; get; }
       public DbSet<MovCaja> MovCaja { set; get; } 

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
       }
    }
}
