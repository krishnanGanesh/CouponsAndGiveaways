﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseRepository.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        T GetById(object[] ids);
        T GetWithNavigational(int id, params string[] navigational);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
