using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Safari.Data.Entities;

namespace Safari.Data.Configuration;

public class MartyrConfiguration : IEntityTypeConfiguration<Martyr>
{
    public void Configure(EntityTypeBuilder<Martyr> builder)
    {
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasColumnType("VARCHAR(50)");

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasColumnType("VARCHAR(50)");

        builder.Property(x => x.FatherFirstName)
            .IsRequired(false)
            .HasColumnType("VARCHAR(50)");

        builder.Property(x => x.BirthDate)
            .IsRequired(false)
            .HasColumnType("VARCHAR(50)");

        builder.Property(x => x.MartyrDate)
            .IsRequired(false)
            .HasColumnType("VARCHAR(50)");

        builder.Property(x => x.Age)
            .IsRequired(false)
            .HasColumnType("SMALLINT");

        builder.Property(x => x.Education)
            .IsRequired(false)
            .HasColumnType("VARCHAR(50)");

        builder.Property(x => x.Job)
            .IsRequired(false)
            .HasColumnType("VARCHAR(50)");

        builder.Property(x => x.BurialPlace)
            .IsRequired(false)
            .HasColumnType("VARCHAR(100)");

        builder.Property(x => x.MartyrPlace)
            .IsRequired(false)
            .HasColumnType("VARCHAR(100)");

        builder.Property(x => x.MissionName)
            .IsRequired(false)
            .HasColumnType("VARCHAR(50)");

        builder.Property(x => x.Marriage)
            .IsRequired(false)
            .HasColumnType("VARCHAR(50)");

        builder.Property(x => x.TestamentText)
            .IsRequired(false)
            .HasColumnType("VARCHAR(500)");

        builder.Property(x => x.Bio)
            .IsRequired(false)
            .HasColumnType("VARCHAR(300)");

        builder.Property(x => x.CreationDate)
            .IsRequired();

        builder.Property(x => x.IsDeleted)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(x => x.PhotoFileUrl)
            .IsRequired(false)
            .HasColumnType("VARCHAR(500)");

        builder.Property(x => x.TestamentFileUrl)
            .IsRequired(false)
            .HasColumnType("VARCHAR(500)");
    }
}