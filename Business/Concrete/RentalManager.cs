using Business.Abstract;
using Business.Constrat;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Rental rental)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), true, Messages.CarsListed);
        }

        public IResult Update(Rental rental)
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
