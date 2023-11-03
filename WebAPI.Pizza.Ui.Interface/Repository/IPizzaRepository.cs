using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Pizza.Ui.Interface.Repository
{
    public interface IPizzaRepository
    {
        public ICollection<WebAPI.Pizza.UI.Models.Pizza> GetAll();
        public ICollection<WebAPI.Pizza.UI.Models.Pizza> Find(Func<WebAPI.Pizza.UI.Models.Pizza, bool> predicate);
        public WebAPI.Pizza.UI.Models.Pizza? GetById(int id);
        public WebAPI.Pizza.UI.Models.Pizza Add(WebAPI.Pizza.UI.Models.Pizza pizza);
        public WebAPI.Pizza.UI.Models.Pizza Update(WebAPI.Pizza.UI.Models.Pizza pizza);
        public bool Delete(WebAPI.Pizza.UI.Models.Pizza pizza);
    }
}
