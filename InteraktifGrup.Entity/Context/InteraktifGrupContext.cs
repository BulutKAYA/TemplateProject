using InteraktifGrup.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteraktifGrup.Entity.Context
{
    public class InteraktifGrupContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-1CAUHSG4;Database=InteractifGrup;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
