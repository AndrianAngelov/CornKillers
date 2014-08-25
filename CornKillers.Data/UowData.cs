using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CornKillers.Models;

namespace CornKillers.Data
{
    public class UowData:IUowData
    {
        private readonly CornKillersContext context;
        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public UowData()
            : this(new CornKillersContext())
        {
        }

        public UowData(CornKillersContext context)
        {
            this.context = context;
        }

        public IRepository<Serial> Serials
        {
            get { return this.GetRepository<Serial>(); }
        }

        public IRepository<ApplicationUser> Users
        {
            get { return this.GetRepository<ApplicationUser>(); }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
