using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Contextx;

namespace DataAccess.Concrete.EntityFramework
{
    public  class EfProductDal: EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal
    {

    }
}
