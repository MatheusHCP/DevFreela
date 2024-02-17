using System.Reflection;
using DevFreela.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Infrastructure.Persistence
{
	public class DevFreelaDbContext : DbContext
    {
        public DevFreelaDbContext()
        {
        }

        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

        }


        public DbSet<Project> Projects { get; set; }

		public DbSet<User> Users{ get; set; }

		public DbSet<Skill> Skills{ get; set; }

        public DbSet<ProjectComment> ProjectComments { get; set; }


       
    }
}

