using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Pizza.Ui.Infrastructure.Database;

namespace WebAPI.Pizza.Ui.Infrastructure.DataLayer
{
    public class BaseSqlServerDataLayer
    {
        private readonly PizzaDbContext _context;

        public BaseSqlServerDataLayer(PizzaDbContext context)
        {
            _context = context;
        }

        public PizzaDbContext Context { get { return _context; } }
    }
}
