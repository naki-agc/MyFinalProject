using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // IEntityRepository<Category>le çalışabilirsin
    public interface ICategoryDal:IEntityRepository<Category>
    {
       
    }
}
