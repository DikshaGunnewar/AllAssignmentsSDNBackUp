using App.Data.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T e);
        void Edit(T e);
        void Remove(T Id);
        IEnumerable <T> GetEmployees();
        T FindById(int Id);
    }
}
