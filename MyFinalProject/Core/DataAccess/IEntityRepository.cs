using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new(); newlenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);  //GetByCategoryId ya da getById bunların hepsini yapabilecgiz
        T Get(Expression<Func<T, bool>> filter);  //Tek bir seceneğin deteyına inmek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
