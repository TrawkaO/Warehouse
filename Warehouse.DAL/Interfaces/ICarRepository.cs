using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Domain.Entity;

namespace Warehouse.DAL.Interfaces
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        Car GetByName(string name);



    }
}
