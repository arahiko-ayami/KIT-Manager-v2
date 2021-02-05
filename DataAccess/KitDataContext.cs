using System.Data.Entity;
using Models;

namespace DataAccess
{
    public class KitDataContext : DbContext
    {
        public KitDataContext() : base("name = KitDataContext")
        {
            var initializer = new MigrateDatabaseToLatestVersion<KitDataContext, Migrations.Configuration>();
            Database.SetInitializer(initializer);
        }
        
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}