using WebAPI.Pizza.Ui.Application.Repository;
using WebAPI.Pizza.Ui.Infrastructure.DataLayer;
using WebAPI.Pizza.Ui.Interface.Infrastructure;
using WebAPI.Pizza.Ui.Interface.Repository;

namespace WebAPI.Pizza.UI.ExtensionsMethod
{
    public static class ExtensionMethodeInjectionLayerRepository
    {
        public static void AddAllinjection(this IServiceCollection services)
        {
            services.AddScoped<IPizzaDataLayer, PizzaDataLayer>();
            services.AddScoped<IPizzaRepository, PizzaRepository>();

        }
    }
}
