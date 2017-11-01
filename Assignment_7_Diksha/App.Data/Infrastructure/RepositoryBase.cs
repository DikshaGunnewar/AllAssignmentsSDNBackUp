using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        private EmployeeContext dataContext;
        private readonly IDbSet<T> dbset;
        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }
        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }
        protected EmployeeContext DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }

        //Add
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
            dataContext.SaveChanges();
        }

        //Edit
        public virtual void Edit(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
            
        }

        //remove
        public virtual void Remove(T entity)
        {
            dbset.Remove(entity);
            dataContext.SaveChanges();
        }

        public virtual T FindById(int id)
        {
            return dbset.Find(id);
           
        }
      
        public virtual IEnumerable<T> GetEmployees()
        {
            return dbset.ToList();
           
        }
    }
}
