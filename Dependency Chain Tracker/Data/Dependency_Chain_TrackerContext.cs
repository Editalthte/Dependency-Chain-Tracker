using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dependency_Chain_Tracker;

namespace Dependency_Chain_Tracker.Data
{
    public class Dependency_Chain_TrackerContext : DbContext
    {
        public Dependency_Chain_TrackerContext (DbContextOptions<Dependency_Chain_TrackerContext> options)
            : base(options)
        {
        }

        public DbSet<Dependency_Chain_Tracker.Lock_And_Key> Lock_And_Key { get; set; }
    }
}
