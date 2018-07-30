using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proj.Aplicacao.Entidades;

namespace Proj.Infra.EntityConfig
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(e => e.Id);
            
            builder.HasOne(c => c.Pessoa)
                .WithMany(p => p.Contatos)
                .HasForeignKey(c => c.PessoaId)
                .HasPrincipalKey(p => p.Id);

            builder.Property(e => e.Celular)
                .HasColumnType("CHAR(15)");
            

            builder.Property(e => e.Email)
                .HasColumnType("CHAR(100)");

            builder.Property(e => e.Facebook)
                .HasColumnType("CHAR(100)");

            builder.Property(e => e.Instagram)
                .HasColumnType("VARCHAR(100)");

            builder.Property(e => e.Telefone)
                .HasColumnType("VARCHAR(15)");

            builder.Property(e => e.Twitter)
                .HasColumnType("VARCHAR(100)");
        }
    }
}