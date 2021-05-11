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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour == 22.00)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),true,Messages.CarsListed);
        }

        public IDataResult<User> GetUserById(int id)
        {
            if (DateTime.Now.Hour == 22.00)
            {
                return new ErrorDataResult<User>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<User>(_userDal.Get(c => c.UserId == id),true,Messages.CarsListed);
        }
    }
}
