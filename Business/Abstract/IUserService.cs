using Core.DataAccess;
using Core.Utilities;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {

        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserById(int id);
    }
}
