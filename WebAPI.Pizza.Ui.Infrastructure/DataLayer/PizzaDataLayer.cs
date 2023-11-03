using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Pizza.Ui.Infrastructure.Database;
using WebAPI.Pizza.Ui.Interface.Infrastructure;
using WebAPI.Pizza.Ui.Interface.UnitOfWork;
using WebAPI.Pizza.UI.Models;

namespace WebAPI.Pizza.Ui.Infrastructure.DataLayer
{
    public class PizzaDataLayer : BaseSqlServerDataLayer, IPizzaDataLayer
    {
        public PizzaDataLayer(PizzaDbContext context) : base(context)
        {
        }

        public IUnitOfWork UnitOfWork => this.Context;

        public UI.Models.Pizza Add(UI.Models.Pizza pizza)
        {
            //Context.Entry<IEnumerable<Ingredient>>(pizza.Ingredients).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            foreach(var item in pizza.Ingredients)
            {
                if (item.Id > 0) Context.Entry<Ingredient>(item).State = EntityState.Modified;
            }
            return Context.Pizzas.Add(pizza).Entity;
        }

        public bool Delete(UI.Models.Pizza pizza)
        {
            bool result = true;
            try
            {
                Context.Pizzas.Remove(pizza);
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public ICollection<UI.Models.Pizza> Find(Func<UI.Models.Pizza, bool> predicate)
        {
            return Context.Pizzas.Where(predicate).ToList();
        }

        public ICollection<UI.Models.Pizza> GetAll()
        {
            return Context.Pizzas.ToList();
        }

        public UI.Models.Pizza? GetById(int id)
        {
            return Context.Pizzas.Find(id);
        }

        public UI.Models.Pizza Update(UI.Models.Pizza pizza)
        {
            return Context.Pizzas.Update(pizza).Entity;
        }
    }
}
