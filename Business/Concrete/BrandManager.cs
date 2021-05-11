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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        
        public IDataResult<Brand> GetBrandById(int id)
        {
            if (DateTime.Now.Hour  < 23 && DateTime.Now.Hour > 22.15)
            {
                return new ErrorDataResult<Brand>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == id), true, Messages.CarsListed);
        }

        public IDataResult<List<Brand>> GetBrands()
        {
            if (DateTime.Now.Hour < 23 && DateTime.Now.Hour > 22.15)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),true);
        }
    }
}
