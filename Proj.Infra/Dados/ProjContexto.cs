using System;
using System.IO;
using System.Xml.Serialization;
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
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
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
            connectionString = connectionString.Replace("=aluno", "=postgre");
            builder.UseNpgsql(connectionString);
            return new ProjContexto(builder.Options);
        }
    }
}