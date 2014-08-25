using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CornKillers.Models;

namespace CornKillers.Data
{
    public interface IUowData : IDisposable
    {
        IRepository<Serial> Serials { get; }

        IRepository<ApplicationUser> Users { get; }

        int SaveChanges();
    }
}
