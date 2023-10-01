﻿using Entities.Concrete;
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
        Car GetById(int id);
        List<Car> GetByBrandId(int brandId);
        List<Car> GetByColorId(int colorId);
        List<Car> GetAll();
    }
}
