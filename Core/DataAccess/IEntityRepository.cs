using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint (kısıt)= where T:class
    //class=referans tip olabilir
    //IEntity= IEntity veya onu implamente edebilen bir nesne olabilir
    //new() : new lenebilir olmalı. IEntity olmasını önlemek için.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//ayrı ayrı şartlı metodlar yazılmasına gerek bırakmıyor
        //filter=NULL; FİLTRESİZSE HEPSİNİ GETİR
        //null değilse ona göre getir
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
