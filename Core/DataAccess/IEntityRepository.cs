﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // new Ientity değilde sadece sınıfları çekmek için
    public interface IEntityRepository<T> where T : class, IEntity , new()// where şartı sadece bizim oluşturduğımuz classları yazabilmek için
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
