using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApp.Models.DAL
{
    public class AllRepository<T> : _IAllRepository<T> where T : class
    {
        private BookDbContext _context;
        private IDbSet<T> dbEntity;
        public AllRepository(BookDbContext _context)
        {
            this._context = _context;
            dbEntity = _context.Set<T>();
        }
        public bool AddModel(T model)
        {
            dbEntity.Add(model);
            return _context.SaveChanges() > 0;
        }
        public bool DeleteModel(int id)
        {
            T model = dbEntity.Find(id);
            dbEntity.Remove(model);
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<T> GetModel()
        {
            return dbEntity.ToList();
        }

        public T GetModelById(int id)
        {
            return dbEntity.Find(id);
        }

        public bool UpdateModel(T model)
        {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}