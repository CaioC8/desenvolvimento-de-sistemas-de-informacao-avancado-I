using LibrarySystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibrarySystem.Infrastructure.Data.Configurations;

public class LivroConfiguration : IEntityTypeConfiguration<Livro>
{
    public void Configure(EntityTypeBuilder<Livro> builder)
    {
        builder.ToTable("livros");
        builder.HasKey(l => l.Id); 
        builder.Property(l => l.Id).HasColumnName("id");
        builder.Property(l=> l.Titulo).HasColumnName("titulo").IsRequired().HasMaxLength(200);
        builder.Property(l=>l.Disponivel).HasColumnName("disponivel");
        builder.Property(l => l.Preco).HasColumnName("preco").HasPrecision(18,2);
        builder.Property(l => l.Disponivel).HasColumnName("categoria");
        builder.Property(l => l.AutorId).HasColumnName("autor_id");
        builder.HasOne(l => l.Autor).WithMany(a => a.Livros).HasForeignKey(l => l.AutorId).OnDelete(DeleteBehavior.Restrict);
    }
}