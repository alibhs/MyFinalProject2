using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Expression link verebilmek icin. ||  filter = null filtre vermesin demek.
    // generic constraint 
    //class : referans tip
    //IEntity : IEntity veya onu implamente eden bir nesne olabilir
    //new() new'lenebilir olmalı (IEntity interface oldugu için newlenemez onu kullanamayız)

    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T , bool>>  filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
