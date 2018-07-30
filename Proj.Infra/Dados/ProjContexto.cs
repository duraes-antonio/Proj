using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Proj.Aplicacao.Entidades;
using Proj.Infra.EntityConfig;

namespace Proj.Infra.Dados
{
    public class ProjContexto : DbContext
    {
        public ProjContexto(DbContextOptions<ProjContexto> opt) : base(opt)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Defina o nome de cada tabela;
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            
            // Aplique a configuração às colunas de cada tabela;
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
        }
    }
    
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ProjContexto>
    {
        public ProjContexto CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Directory.GetCurrentDirectory()) + "/Proj.MVC")
                .AddJsonFile("appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<ProjContexto>();
            var connectionString = configuration.GetConnectionString("ConStrPsql");
            
            // Trecho que define a senha do banco da string de connexão acima; 
            var senha = "=aluno";
            connectionString = connectionString.Replace("=aluno", senha);
            
            builder.UseNpgsql(connectionString);
            return new ProjContexto(builder.Options);
        }
    }
}