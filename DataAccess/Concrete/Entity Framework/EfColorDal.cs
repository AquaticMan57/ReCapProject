using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, NorthwindContext>, IColorDal
    {
        public List<ColorDetailDto> GetColorDetails()
        {
            throw new NotImplementedException();
        }
    }
}
