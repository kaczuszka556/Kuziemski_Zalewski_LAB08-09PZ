using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
namespace Kuziemski_Zalewski_LAB08_09PZ_BK
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Wydarzenie> Wydarzenia { get; set; }
        public DbSet<Preferencje> Preferencjes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
    }
}
