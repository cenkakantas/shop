using Microsoft.EntityFrameworkCore;
using shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace shop.Dal.Concrate.EntityFramework
{
   public class EgitimDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Dat Source= ");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
