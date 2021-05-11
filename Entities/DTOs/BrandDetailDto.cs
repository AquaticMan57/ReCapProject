using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public  class BrandDetailDto
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public short UnitsInStock { get; set; }
    }
}
