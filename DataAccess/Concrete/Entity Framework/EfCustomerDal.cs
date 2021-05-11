using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            throw new NotImplementedException();
        }
    }
}
