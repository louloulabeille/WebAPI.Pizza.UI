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
    public class IngredientDataLayer : BaseSqlServerDataLayer, IIngredientDataLayer
    {
        public IngredientDataLayer(PizzaDbContext context) : base(context)
        {
        }

        public IUnitOfWork UnitOfWork => this.UnitOfWork;

        public Ingredient Add(Ingredient ingredient)
        {
            return Context.Ingredients.Add(ingredient).Entity;
        }

        public bool Delete(Ingredient ingredient)
        {
            bool retour = true;
            try
            {
                Context.Remove(ingredient);
            }
            catch
            {
                retour = false;
            }
            return retour;
        }

        public ICollection<Ingredient> Find(Func<Ingredient, bool> predicate)
        {
            return Context.Ingredients.Where(predicate).ToList();
        }

        public ICollection<Ingredient> GetAll()
        {
            return Context.Ingredients.ToList();
        }

        public ICollection<Ingredient>? GetAllByPizza(int pizzaId)
        {
            //Context.Pizzas.Include("Ingredients").Where(x => x.Id == pizzaId).FirstOrDefault()?.Ingredients.ToList();
            return Context.Pizzas.Find(pizzaId)?.Ingredients.ToList();
        }

        public Ingredient? GetById(int id)
        {
            return Context.Ingredients.Find(id);
        }

        public Ingredient Update(Ingredient ingredient)
        {
            return Context.Update(ingredient).Entity;
        }
    }
}
