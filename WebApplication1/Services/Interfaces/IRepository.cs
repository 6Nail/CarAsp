using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.Interfaces
{
    public interface IRepository
    {
        void Create(Car car);
        void Edit(Car car);
        void Delete(Guid car);
        Car Get(Guid id);
        ICollection<Car> GetAll();
    }
}
