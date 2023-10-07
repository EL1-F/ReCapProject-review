using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarSerivce
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.CarName.Length>=2)
            {
                _carDal.Add(car);
            }
            else
            {
                if (car.DailyPrice<=0)
                {
                    Console.WriteLine("Günlük fiyat sıfır olamaz");

                }else if (car.CarName.Length < 2)
                {
                    Console.WriteLine("Araba ismi en az 2 karakter olabilir.");
                }
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c=>c.BrandId==brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c=>c.ColorId==colorId);
        }

        public Car GetByCarId(int id)
        {
            return _carDal.Get(c=>c.CarId==id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
