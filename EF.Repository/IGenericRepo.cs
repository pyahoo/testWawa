﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Repository
{
    public interface IGenericRepo<T>
    {
        List<T> GetAll();
        Task<List<T>> GetAllAsync();

        T GetById(int id);
        void Add(T t);
        void Delete(int id);
        void Update(int id, T t);
    }
}
