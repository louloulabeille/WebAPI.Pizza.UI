using WebAPI.Pizza.Ui.Interface.Infrastructure;
using WebAPI.Pizza.Ui.Interface.Repository;

namespace WebAPI.Pizza.Ui.Application
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly IPizzaDataLayer _layer;

        public PizzaRepository(IPizzaDataLayer layer)
        {
            _layer = layer;
        }

        public UI.Models.Pizza Add(UI.Models.Pizza pizza)
        {
            return _layer.Add(pizza);
        }

        public bool Delete(UI.Models.Pizza pizza)
        {
            return _layer.Delete(pizza);
        }

        public ICollection<UI.Models.Pizza> Find(Func<UI.Models.Pizza, bool> predicate)
        {
            return _layer.Find(predicate);
        }

        public ICollection<UI.Models.Pizza> GetAll()
        {
            return _layer.GetAll();
        }

        public UI.Models.Pizza? GetById(int id)
        {
            return _layer.GetById(id);
        }

        public UI.Models.Pizza Update(UI.Models.Pizza pizza)
        {
            return _layer.Update(pizza);
        }
    }
}