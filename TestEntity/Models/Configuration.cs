using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntity.Models
{
    internal sealed class Configuration : DbMigrationsConfiguration<HogeDbContext>
    {
        //自動マイグレーション機能を有効にする。
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "TestEntity.Models.HogeDbContext";
        }
    }
}
