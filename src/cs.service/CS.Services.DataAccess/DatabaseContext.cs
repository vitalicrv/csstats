using System.Data.Entity;
using CS.Service.Data;

namespace CS.Service.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=DatabaseContext")
        {
            //Turning off migrations
            Database.SetInitializer<DatabaseContext>(null);
        }

        public DbSet<Statistics> Statistics { get; set; }
    }
}
