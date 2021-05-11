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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CarAdded);
        }
        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            if (DateTime.Now.Hour == 00.00)
            {
                return new ErrorDataResult<List<Customer>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),true,Messages.CarsListed);
        }

        public IDataResult<List<Customer>> GetById()
        {
            if (DateTime.Now.Hour == 00.00)
            {
                return new ErrorDataResult<List<Customer>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), true, Messages.CarsListed);
        }
        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
