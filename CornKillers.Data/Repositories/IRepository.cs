using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CornKillers.Data.Repositories
{
    public interface IRepository<T> where T:class
    {
        void Add(T item);
        void Delete(int id);
        IQueryable<T> GetAll();
        object Get(int id);
        void Upadate(int id, T item);
    }
}
