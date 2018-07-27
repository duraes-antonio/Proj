using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Proj.Aplicacao.Entidades;

namespace Proj.Infra.Dados
{
    public class ProjContexto : DbContext
    {

        public ProjContexto(DbContextOptions<ProjContexto> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
//            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
        }
    }
    
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ProjContexto>
    {
        public ProjContexto CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Directory.GetCurrentDirectory()) + "/Proj.MVC")
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<ProjContexto>();
            var connectionString = configuration.GetConnectionString("ConStrPsql");
            builder.UseNpgsql(connectionString);
            return new ProjContexto(builder.Options);
        }
    }
}