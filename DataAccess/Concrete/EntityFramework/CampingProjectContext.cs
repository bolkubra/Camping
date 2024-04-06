using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CampingProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database=CampingProject;Trusted_Connection=true");
        }
        public DbSet<City> Citys { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CampPlace> CampPlaces { get; set;}
        public DbSet<Image> Images { get; set; }
    }
}
