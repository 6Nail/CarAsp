using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Enum_s;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Services.Implementations
{
    public class Repository : IRepository
    {
        private readonly IList<Car> _cars;
        public Repository()
        {
            _cars = new List<Car>()
            {
                new Car
                {
                    BodyType = BodyType.Cabriolet,
                    Brand = "Honda",
                    BodyColor = BodyColor.White,
                    Power = 1.6
                },
                new Car
                {
                    BodyType = BodyType.Sedan,
                    Brand = "BMW",
                    BodyColor = BodyColor.Black,
                    Power = 1.6
                }
            };
        }
        public void Create(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Guid id)
        {
            _cars.Remove(_cars.FirstOrDefault(x => x.Id == id));
        }

        public void Edit(Car car)
        {
            _cars[_cars.ToList().FindIndex(x => x.Id == car.Id)] = car;
        }

        public Car Get(Guid id)
        {
            return _cars.FirstOrDefault(x => x.Id == id);
        }

        public ICollection<Car> GetAll()
        {
            return _cars;
        }
    }
}
