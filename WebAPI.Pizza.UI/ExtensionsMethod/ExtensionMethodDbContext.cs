using Microsoft.EntityFrameworkCore;
using WebAPI.Pizza.Ui.Infrastructure.Database;

namespace WebAPI.Pizza.UI.ExtensionsMethod
{
    public static class ExtensionMethodDbContext
    {
        public static void AddAllDbContext(this IServiceCollection services, ConfigurationManager configuration) {
            var connectionString = configuration.GetConnectionString("PizzaConnection");

            services.AddDbContext<PizzaDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
