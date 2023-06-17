using Aula19_AS_Final.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AutorMap : IEntityTypeConfiguration<Autor>
{
    public void Configure(EntityTypeBuilder<Autor> builder)
    {
        builder.ToTable("Autores");

        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id).HasColumnName("Id").ValueGeneratedOnAdd();

        builder.Property(a => a.Nome).HasColumnName("Nome").HasMaxLength(100).IsRequired();
    }
}
