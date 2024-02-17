using DevFreela.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProjectCommentMap : IEntityTypeConfiguration<ProjectComment>
{
    public void Configure(EntityTypeBuilder<ProjectComment> builder)
    {
        builder.HasKey(u => u.Id);
    }
}