using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Safari.Data.Entities;

namespace Safari.Data.Configuration;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.Property(x => x.Text)
            .IsRequired()
            .HasColumnType("VARCHAR(200)");

        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasColumnType("VARCHAR(50)");

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasColumnType("VARCHAR(50)");

        builder.Property(x => x.PhoneNumber)
            .IsRequired()
            .HasColumnType("VARCHAR(11)");

        builder.Property(x => x.IsApproved)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(x => x.CreationDate)
            .IsRequired();

        builder.Property(x => x.IsDeleted)
            .IsRequired()
            .HasDefaultValue(false);

        builder.HasOne(x => x.Martyr)
            .WithMany(x => x.Comments)
            .HasForeignKey(x => x.MartyrId)
            .HasConstraintName("FK_Comment_Martyr");
    }
}