using MySql.Data.EntityFramework;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareIIb.DAL.Configurations
{
    internal class MySqlDataConfiguration : DbConfiguration
    {
        public MySqlDataConfiguration() : base() {
            SetExecutionStrategy(MySqlProviderInvariantName.ProviderName, () => new MySqlExecutionStrategy());
            SetMigrationSqlGenerator("MySql.Data.MySqlClient", () => new MySqlMigrationSqlGenerator());
        }
    }
}
