using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Pizza.Ui.Infrastructure.Database
{
    public class PizzaContextFactory : IDesignTimeDbContextFactory<PizzaDbContext>
    {
        public PizzaDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<PizzaDbContext> optionsBuilder = new ();
            optionsBuilder.UseSqlServer("Server=localhost;Database=Pizza-Dev;User Id=sa;Password=ieupn486jadF&;TrustServerCertificate=true;");

            return new PizzaDbContext(optionsBuilder.Options);
        }
    }
}
