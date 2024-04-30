using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareIIb.DAL.Interceptors
{
    internal class UtcParameterAdjust : DbCommandInterceptor
    {
        public override void ReaderExecuting(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            foreach (DbParameter dbParameter in command.Parameters)
            {
                if (dbParameter.Value is DateTime dtLocal)
                {
                    if (dtLocal.Kind != DateTimeKind.Utc)
                    {
                        dbParameter.Value = dtLocal.ToUniversalTime();
                    }
                }
            }
            base.ReaderExecuting(command, interceptionContext);
        }

    }
}
