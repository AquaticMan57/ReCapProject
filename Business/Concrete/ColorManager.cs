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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAllColors()
        {
            if (DateTime.Now.Hour < 23.00 && DateTime.Now.Hour > 22.15)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);

            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), true,Messages.CarsListed);
        }

        public IDataResult<Color> GetColorById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == id), Messages.CarsListed);
        }

    }
}
