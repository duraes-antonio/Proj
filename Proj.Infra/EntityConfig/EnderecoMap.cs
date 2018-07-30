using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proj.Aplicacao.Entidades;

namespace Proj.Infra.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Pessoa)
                .WithOne(p => p.Endereco)
                .HasForeignKey<Endereco>(e => e.PessoaId);

            builder.Property(e => e.Bairro)
                .HasColumnType("VARCHAR(100)").IsRequired();
            
            builder.Property(e => e.Cep)
                .HasColumnType("CHAR(11)").IsRequired();
            
            builder.Property(e => e.Cidade)
                .HasColumnType("VARCHAR(100)").IsRequired();
            
            builder.Property(e => e.EstadoSigla)
                .HasColumnType("CHAR(2)").IsRequired();
            
            builder.Property(e => e.Logradouro)
                .HasColumnType("VARCHAR(100)").IsRequired();
            
            builder.Property(e => e.Numero)
                .HasColumnType("INT").IsRequired();
        }
    }
}