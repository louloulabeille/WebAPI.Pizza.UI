using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebAPI.Pizza.UI.Models
{
    public class Ingredient
    {
        public int Id { get; set; }    
        public string Nom { get; set; }

        [NotMapped]
        [JsonIgnore]
        public ICollection<Pizza>? pizzas { get; set; }
    }
}
