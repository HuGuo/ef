using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Entity;
using EF.Model;

namespace EF.Dal
{
    public abstract class Repository<TEntity> where TEntity : class
    {
        public virtual List<TEntity> FindAll()
        {
            var db = new Content();
            return db.Set<TEntity>().ToList();
        }

        public virtual TEntity Find(object obj)
        {
            var db = new Content();
            return db.Set<TEntity>()
                .Find(obj);
        }

        public void Add(TEntity entity)
        {
            var db = new Content();
            db.Set<TEntity>().Add(entity);
            db.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            var db = new Content();
            db.Set<TEntity>().Attach(entity);
            db.Entry<TEntity>(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Del(TEntity entity)
        {
            var db = new Content();
            db.Set<TEntity>().Attach(entity);
            db.Entry<TEntity>(entity).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public void Del(object obj)
        {
            var db = new Content();
            var entity = db.Set<TEntity>().Find(obj);
            db.Set<TEntity>().Attach(entity);
            db.Entry<TEntity>(entity).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
