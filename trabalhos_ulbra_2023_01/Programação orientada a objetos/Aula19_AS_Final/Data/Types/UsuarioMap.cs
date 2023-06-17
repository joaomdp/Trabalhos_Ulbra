using Aula19_AS_Final.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UsuarioMap : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuarios");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnName("Id").ValueGeneratedOnAdd();

        builder.Property(u => u.Nome).HasColumnName("Nome").HasMaxLength(100).IsRequired();
    }
}
