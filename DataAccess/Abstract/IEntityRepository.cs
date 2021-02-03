using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //where T:class generic constraint
    //class olur demek değil referans tip demek
    // t ya Ientity olabilir ya da referans alacak bir generic olabilir
    //IEntity : IEntity olabilir veya IEntity implemenre eden bir nesen olabilir.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T GetT(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
