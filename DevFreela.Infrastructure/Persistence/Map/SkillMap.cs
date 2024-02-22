using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SkillMap : IEntityTypeConfiguration<Skill>
{
    public void Configure(EntityTypeBuilder<Skill> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(p => p.Description).IsRequired();
        builder.Property(p => p.CreatedAt).HasColumnType("Date").IsRequired();
    }
}