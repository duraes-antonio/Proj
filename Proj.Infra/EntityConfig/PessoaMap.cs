using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Proj.Aplicacao.Entidades;

namespace Proj.Infra.EntityConfig
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(e => e.Id);
            
            builder.HasMany(pess => pess.Contatos)
                .WithOne(cont => cont.Pessoa)
                .HasForeignKey(cont => cont.PessoaId)
                .HasPrincipalKey(pess => pess.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Endereco)
                .WithOne(e => e.Pessoa)
                .HasForeignKey<Endereco>(e => e.PessoaId);
                
            builder.Property(e => e.Cpf)
                .HasColumnType("CHAR(11)")
                .IsRequired();

            builder.Property(e => e.DataNasc)
                .HasColumnType("TIMESTAMP")
                .IsRequired();
            
            builder.Property(e => e.DataCadastro)
                .HasColumnType("TIMESTAMP")
                .IsRequired();

            builder.Property(e => e.Email)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnType("VARCHAR(150)")
                .IsRequired();
        }
    }
}