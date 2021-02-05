using System.Data.Entity.Migrations;


namespace DataAccess.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.KitDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    } 
}