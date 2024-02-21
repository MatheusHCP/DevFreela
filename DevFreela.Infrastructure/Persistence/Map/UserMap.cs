using DevFreela.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(p => p.FullName).IsRequired().HasMaxLength(250);
        builder.Property(p => p.Email).IsRequired().HasMaxLength(250);
        builder.Property(p => p.BirthDate).HasColumnType("Date").IsRequired();
        builder.Property(p => p.CreatedAt).HasColumnType("Date").IsRequired();
        builder.Property(p => p.Active).IsRequired();
    }
}