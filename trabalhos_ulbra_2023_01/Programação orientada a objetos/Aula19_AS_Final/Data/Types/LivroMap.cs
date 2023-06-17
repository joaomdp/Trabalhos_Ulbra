using Aula19_AS_Final.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class LivroMap : IEntityTypeConfiguration<Livro>
{
    public void Configure(EntityTypeBuilder<Livro> builder)
    {
        builder.ToTable("Livros");

        builder.HasKey(l => l.Id);
        builder.Property(l => l.Id).HasColumnName("Id").ValueGeneratedOnAdd();

        builder.Property(l => l.Titulo).HasColumnName("Titulo").HasMaxLength(100).IsRequired();

        builder.HasMany(l => l.Autores)
               .WithMany(a => a.Livros)
               .UsingEntity<Dictionary<string, object>>(
                    "LivroAutor",
                    j => j.HasOne<Autor>().WithMany().HasForeignKey("AutorId"),
                    j => j.HasOne<Livro>().WithMany().HasForeignKey("LivroId"),
                    j =>
                    {
                        j.HasKey("LivroId", "AutorId");
                        j.ToTable("LivroAutor");
                    }
                );

        builder.HasMany(l => l.UsuariosEmprestados)
               .WithMany(u => u.LivrosEmprestados)
               .UsingEntity<Dictionary<string, object>>(
                    "LivroUsuario",
                    j => j.HasOne<Usuario>().WithMany().HasForeignKey("UsuarioId"),
                    j => j.HasOne<Livro>().WithMany().HasForeignKey("LivroId"),
                    j =>
                    {
                        j.HasKey("LivroId", "UsuarioId");
                        j.ToTable("LivroUsuario");
                    }
                );
    }
}
