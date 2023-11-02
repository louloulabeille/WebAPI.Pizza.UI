using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Pizza.Ui.Interface.UnitOfWork
{
    public interface IUnitOfWork
    {
        public int SaveChanges();
    }
}
