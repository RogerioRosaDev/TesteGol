

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SIS_GOL.Domain;
using System.IO;

namespace SIS_GOL.Infra.DataAccess
{
    public class GOL_Context : DbContext
    {
        // public GOL_Connection()
        // {

        // }
        public GOL_Context(DbContextOptions<GOL_Context> options) : base(options)
        {

        }
        public DbSet<Airplane> Airplane { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AirplaneMap());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            optionsBuilder.UseSqlServer(GetConnectionString());
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            //.UseLazyLoadingProxies();

        }

        private static string GetConnectionString()
        {
            return "Server=DESKTOP-ABT071V;Database=TESTE_GOL;Trusted_Connection=True;User ID=sa; Password=Pa$$w0rd; MultipleActiveResultSets=true";
        }
    }
}
