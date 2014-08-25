using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CornKillers.Models;

namespace CornKillers.Data
{
    public class CornKillersContext : DbContext
    {
        public CornKillersContext()
            : base("CornKillersDb")
        {

        }

        public DbSet<Serial> Series { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
