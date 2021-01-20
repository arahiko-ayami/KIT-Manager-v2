
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

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