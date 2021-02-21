using Core.DateAcces.EntitiyFrameWork;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFrameWork
{
    public class EfOrderDal:EfEntityRepositoryBase<Order, NorthwindContext>,IOrderDal
    {
    }
}
