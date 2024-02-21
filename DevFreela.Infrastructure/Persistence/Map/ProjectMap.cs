using DevFreela.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProjectMap : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(p => p.Title).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Description).HasMaxLength(100);
        builder.Property(p => p.TotalCost).IsRequired().HasPrecision(9,2);
        builder.Property(p => p.CreatedAt).HasColumnType("Date").IsRequired();
        builder.Property(p => p.StartedAt).HasColumnType("Date");
        builder.Property(p => p.FinishedAt).HasColumnType("Date");
        builder.Property(p => p.Status).IsRequired();


        #region Foreign Keys

        builder.HasMany(p => p.ProjectComments).WithOne(p => p.Project).HasForeignKey(p => p.IdProject);
        builder.HasOne(p => p.User).WithMany(us => us.Projects).HasForeignKey(p => p.IdClient).IsRequired();
        builder.HasOne(p => p.User).WithMany(us => us.Projects).HasForeignKey(p => p.IdFreeLancer).IsRequired();

        #endregion



    }
}