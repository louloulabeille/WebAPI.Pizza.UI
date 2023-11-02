using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Pizza.Ui.Interface.UnitOfWork;

namespace WebAPI.Pizza.Ui.Interface.Infrastructure
{
    public interface IDataLayer
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
