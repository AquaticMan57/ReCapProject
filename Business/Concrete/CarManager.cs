using Business.Abstract;
using Business.Constrat;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length < 2 && car.CarName.Length > 20)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            if (car.CarName.Length< 2 && car.CarName.Length> 20)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Car car)
        {
            if (car.CarName.Length <2 && car.CarName.Length > 20)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Update(car);
            return new SuccessResult(Messages.CarAdded);
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour > 22.15 && DateTime.Now.Hour <23.00)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),true,Messages.CarsListed);
        }
        //
        public IDataResult<List<Car>> GetCars()
        {
            if (DateTime.Now.Hour > 22.15 && DateTime.Now.Hour < 23.00)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max)
        {
            if (DateTime.Now.Hour > 22.15 && DateTime.Now.Hour < 23.00)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice > min && c.DailyPrice < max),true,Messages.CarsListed);
        }

        public IDataResult<Car> GetCarById(int id)
        {
            if (DateTime.Now.Hour > 22.15 && DateTime.Now.Hour < 23.00)
            {
                return new ErrorDataResult<Car>(Messages.MaintenanceTime);

            }
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id),Messages.CarsListed);
        }

        
    }
}
