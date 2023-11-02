using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Pizza.Ui.Infrastructure.Database.EnitityConfiguration
{
    public class PizzaEntityConfiguration : IEntityTypeConfiguration<WebAPI.Pizza.UI.Models.Pizza>
    {
        public void Configure(EntityTypeBuilder<UI.Models.Pizza> builder)
        {
            builder.ToTable(nameof(WebAPI.Pizza.UI.Models.Pizza));
            builder.HasKey(p => p.Id);

            builder.Property(x=>x.Id).IsRequired()
                .HasAnnotation("SqlServer:Identity","1,1");

            builder.Property(x => x.Nom).IsRequired()
                .HasMaxLength(80);

            builder.Property(x => x.Prix).IsRequired();

            builder.HasMany(x => x.Ingredients)
                .WithMany(p => p.pizzas);
            
        }
    }
}
