using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Core katmanı başka katmanlara bağımlı değildir
    //generic constraint - kısıtlama
    //class : refereans tip olablir
    //ya IEntity olabilir yada implemente olmuş bir class gelebilir
    //new() new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class, IEntity, new ()
    {
        //null demek filtre vermeyebileceğimiz anlamına gelir
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
