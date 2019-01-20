using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datagrid_Databinding_Example.Model.Repository
{
    public abstract class BaseRepo<T> : IDisposable where T : class, new()
    {
        public ContextClass Context { get; } = ContextClass.GetInstance();
        protected DbSet<T> Table;

        public T GetOne(int? id) => Table.Find(id);
        public List<T> GetAll() => Table.ToList();
        public int Add(T entity)
        {
            Table.Add(entity);
            return SaveChanges();
        }
        public int AddRange(IEnumerable<T> entities)
        {
            Table.AddRange(entities);
            return SaveChanges();
        }
        public int AddRange(IList<T> entities)
        {
            Table.AddRange(entities);
            return SaveChanges();
        }
        public int Save(T entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return SaveChanges();
        }
        public int Delete(T entity)
        {
            Table.Remove(entity);
            return SaveChanges();
        }

        public List<T> ExecuteQuery(string sql) => Table.SqlQuery(sql).ToList();
        public List<T> ExecuteQuery(string sql, object[] sqlParametersObjects)
        {
            return Table.SqlQuery(sql, sqlParametersObjects).ToList();
        }
        internal int SaveChanges()
        {
            return Context.SaveChanges();
        }

        bool _disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {

            if (!this._disposed)
            {
                if (disposing)
                {
                    ContextClass.GetInstance().Dispose();
                }
            }
            this._disposed = true;
        }
    }
}
