using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetCars();
        IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetCarById(int id);
        IResult Delete( Car car);
        IResult Add(Car car);
        IResult Update(Car car);
    }
}
