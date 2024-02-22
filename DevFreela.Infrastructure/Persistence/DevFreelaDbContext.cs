﻿using System.Reflection;
using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Infrastructure.Persistence
{
	public class DevFreelaDbContext : DbContext
    {


        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
        {
        }

        public DevFreelaDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {

            }
        }


        public DbSet<Project> Projects { get; set; }

		public DbSet<User> Users{ get; set; }

		public DbSet<Skill> Skills{ get; set; }

        public DbSet<ProjectComment> ProjectComments { get; set; }


       
    }
}

