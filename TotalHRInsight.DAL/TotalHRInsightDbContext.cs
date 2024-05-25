using Microsoft.EntityFrameworkCore;

namespace TotalHRInsight.DAL
{
    public class TotalHRInsightDbContext : DbContext
    {
        public TotalHRInsightDbContext() { }
        public TotalHRInsightDbContext(DbContextOptions<TotalHRInsightDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionString = "server=127.0.0.1;database=Prueba;User=root;Password=123456789";
            var connectionString = "server=viaduct.proxy.rlwy.net;database=railway;port=32013;User=root;Password=hVYCFgtlWkqHIiqyhWjcOCCNVhHxELRS";
            //var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        public virtual DbSet<Sucursal> Sucursales { get; set; }
        public virtual DbSet<Planilla> Planillas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<Asistencia> Asistencias { get; set; }


    }
}
