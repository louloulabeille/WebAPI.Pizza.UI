using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Pizza.UI.Models;

namespace WebAPI.Pizza.Ui.Interface.Infrastructure
{
    public interface IIngredientDataLayer : IDataLayer
    {
        public ICollection<Ingredient> GetAll();
        public ICollection<Ingredient> Find(Func<Ingredient, bool> predicate);
        public Ingredient? GetById(int id);
        public Ingredient Add(Ingredient ingredient);
        public Ingredient Update(Ingredient ingredient);
        public ICollection<Ingredient>? GetAllByPizza(int pizzaId);
        public bool Delete(Ingredient ingredient);
    }
}
