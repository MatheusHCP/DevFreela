using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProjectCommentMap : IEntityTypeConfiguration<ProjectComment>
{
    public void Configure(EntityTypeBuilder<ProjectComment> builder)
    {
        builder.HasKey(u => u.Id);
        builder.Property(p => p.Content).IsRequired().HasMaxLength(250);
        builder.Property(p => p.CreatedAt).HasColumnType("Date").IsRequired();

        #region Foreign Keys

        builder.HasOne(p => p.User).WithMany(p => p.ProjectComments).HasForeignKey(p => p.IdUser);

        #endregion

    }
}