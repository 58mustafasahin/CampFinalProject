﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint (generic kısıtlaması yapıldı)
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı (IEntity interface olduğundan new'lenemez)
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}