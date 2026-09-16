using LibrarySystem.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibrarySystem.Infrastructure.Data.Configurations;

public class AutorConfiguration : IEntityTypeConfiguration<Autor>
{
    public void Configure(EntityTypeBuilder<Autor> builder)
    {
        builder.ToTable("autores");
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Nome).HasColumnName("nome").IsRequired().HasMaxLength(150);
        builder.Property(a => a.Nacionalidade).HasColumnName("nacionalidade").HasMaxLength(80);
    }
}