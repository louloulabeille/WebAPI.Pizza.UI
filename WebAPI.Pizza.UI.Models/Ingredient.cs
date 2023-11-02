using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Pizza.UI.Models
{
    public class Ingredient
    {
        public int Id { get; set; }    
        public string Nom { get; set; }
        public ICollection<Pizza> pizzas { get; set; }
    }
}
