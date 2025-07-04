﻿using Microsoft.EntityFrameworkCore;
using PetProject.Configurations;
using PetProject.Models;

namespace PetProject
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { } 

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<GameEntity> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new GameConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
