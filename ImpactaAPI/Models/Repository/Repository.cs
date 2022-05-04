using ImpactaAPI.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ImpactaAPI.Models.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private BdContext _context;
        private DbSet<T> table;

        #region Ctor
        public Repository(BdContext context)
        {

            _context = context;
            table = _context.Set<T>();
        }
        #endregion

        public T Find(int id)
        {
            return table.Find(id);
        }

        public IQueryable<T> List()
        {
            return table;
        }

        public void Add(T item)
        {
            table.Add(item);
        }

        public void Remove(T item)
        {
            table.Remove(item);
        }

        public void Edit(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public T FirstOrDeafault(Expression<Func<T, bool>> clause)
        {
            return table.FirstOrDefault(clause);
        }

        public IEnumerable<T> Where(Expression<Func<T, bool>> clause)
        {
            return table.Where(clause);
        }
    }
}
