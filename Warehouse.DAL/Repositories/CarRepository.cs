using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Warehouse.DAL.Interfaces;
using Warehouse.Domain.Entity;

namespace Warehouse.DAL.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _context;

        public CarRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Create(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Car>> Select()
        {
            return _context.Car.ToListAsync();
        }

        public bool Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
