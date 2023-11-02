using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Pizza.UI.Models;

namespace WebAPI.Pizza.Ui.Infrastructure.Database.EnitityConfiguration
{
    public class IngredientEntityConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.ToTable(nameof(Ingredient));
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Nom).IsRequired()
                .HasMaxLength(80);

            builder.HasMany(x => x.pizzas)
                .WithMany(x => x.Ingredients);
        }
    }
}
