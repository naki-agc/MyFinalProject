using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // IEntityRepository<Product>la çalışabilirsin
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
