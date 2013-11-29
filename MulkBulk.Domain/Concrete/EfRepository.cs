using MulkBulk.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MulkBulk.Domain.Concrete
{
    public class EfRepository<T> : IRepository<T> where T : class
    {

        protected DbContext Context;
        protected readonly bool ShareContext;

        public EfRepository(DbContext context) : this(context, false) { }
        public EfRepository(DbContext context, bool shareContext)
        {

            Context = context;
            ShareContext = shareContext;
        }

        public IDbSet<T> ContextDbSet
        {
            get { return Context.Set<T>(); }
        }
        public IQueryable<T> All()
        {
            return   ContextDbSet.AsQueryable();
        }

        public bool Any(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return ContextDbSet.Any(predicate);
        }

        public int Count
        {
            get { return ContextDbSet.Count(); }
        }

        public T Create(T t)
        {
            ContextDbSet.Add(t);

            if (!ShareContext)
            {
                Context.SaveChanges();
            }
            return t;
        }

        public int Delete(T t)
        {
            ContextDbSet.Remove(t);
            if (!ShareContext) 
            {
                Context.SaveChanges();
            
            }
            return 0;
        }

        public int Delete(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            var records = FindAll(predicate);

            foreach (var record in records)
            {
                ContextDbSet.Remove(record);
            }
            return 0;
        }

        public T Find(params object[] keys)
        {
            return ContextDbSet.Find(keys);
        }

        public T Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return ContextDbSet.SingleOrDefault(predicate);
        }

        public IQueryable<T> FindAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return ContextDbSet.Where(predicate).AsQueryable();
        }

        public IQueryable<T> FindAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate, int index, int size)
        {
            var skip = index * size;
            IQueryable<T> query = ContextDbSet;
            if(predicate != null)
            {
                query = query.Where(predicate);
            }
            if (skip != null) {
                query.Skip(skip);
            }

            return query.Take(size).AsQueryable();
        }

        public int Update(T t)
        {
            var entity = Context.Entry(t);

            ContextDbSet.Attach(t);

            entity.State = System.Data.Entity.EntityState.Modified;

            if(!ShareContext)
            {
                Context.SaveChanges();
            }
            return 0;

        }

        public void Dispose()
        {
            if (!ShareContext && Context != null)
            {
                try
                {
                    Context.Dispose();
                }
                catch { }
            }
        }
    }
}