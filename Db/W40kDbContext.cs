using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DbModel;

namespace Db
{
    public class W40kDbContext : DbContext
    {
        public DbSet<UnitType> UnitTypes { get; set; }

        public DbSet<Faction> Factions { get; set; }
    }
}
