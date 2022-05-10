using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PlanoMap : IEntityTypeConfiguration<PlanosEntity>
    {
        public void Configure(EntityTypeBuilder<PlanosEntity> builder)
        {
            builder.ToTable("Planos");

            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.IdPlano).IsUnique();
            builder.Property(p => p.IdPlano).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Minutos).IsRequired().HasMaxLength(10);
            builder.Property(p => p.Operadora).IsRequired().HasMaxLength(50);
            builder.Property(p => p.TipoPlano).IsRequired().HasMaxLength(8);
            builder.Property(p => p.Valor).IsRequired().HasMaxLength(50);
        }
    }
}
