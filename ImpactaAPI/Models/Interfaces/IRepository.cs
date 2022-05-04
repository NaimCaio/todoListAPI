﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ImpactaAPI.Models.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Find(int id);
        IQueryable<T> List();
        void Add(T item);
        void Remove(T item);
        void Edit(T item);

        void Save();
        T FirstOrDeafault(Expression<Func<T, bool>> clause);
        IEnumerable<T> Where(Expression<Func<T, bool>> clause);

    }
}
