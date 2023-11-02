﻿using Microsoft.EntityFrameworkCore;
using WebAPI.Pizza.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Pizza.Ui.Infrastructure.Database.EnitityConfiguration;

namespace WebAPI.Pizza.Ui.Infrastructure.Database
{
    public class PizzaDbContext : DbContext
    {
        public PizzaDbContext(DbContextOptions options) : base(options)
        {
        }

        #region DbSet
        public virtual DbSet<WebAPI.Pizza.UI.Models.Pizza> Pizzas { get; set; }
        #endregion

        #region Configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<WebAPI.Pizza.UI.Models.Pizza>(new PizzaEntityConfiguration());
            modelBuilder.ApplyConfiguration<Ingredient>(new IngredientEntityConfiguration());
        }
        #endregion
    }
}