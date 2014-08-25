using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CornKillers.Data
{
    public interface IRepository<T> where T:class
    {
        IQueryable<T> All();

        T GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(int id);

        void Detach(T entity);

        //void Add(T item);
        //void Delete(int id);
        //IQueryable<T> GetAll();
        //object Get(int id);
        //void Upadate(int id, T item);
    }
}
