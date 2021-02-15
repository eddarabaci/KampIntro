using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    public interface IEntityRepository<T> where T:class,IEntity
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);  //GetByCategoryId ya da getById bunların hepsini yapabilecgiz
        T Get(Expression<Func<T, bool>> filter);  //Tek bir seceneğin deteyına inmek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
