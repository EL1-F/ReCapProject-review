using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarSerivce
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        Car GetByCarId(int id);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetAll();
    }
}
