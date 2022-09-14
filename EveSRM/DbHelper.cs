using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveSRM
{
    public class DbHelper
    {
        private static string connectionString = $@"{AppSettings.app(new string[] { "ConnectionStrings", "Oracle" })}";
        //private static string connectionString = "User Id=WMS_FTEST;Password=\'1RT,z9Z*Lpo;\';Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.1.3.96)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=wmsdev)));Pooling=true;Max Pool Size=300;Min Pool Size=0;Connection Lifetime=300;";

        public DbHelper() { }

        public static DbConnection conn
        {
            get
            {
                return (DbConnection)CreateOracleConnection();
            }
        }

        protected static IDbConnection CreateOracleConnection()
        {
            IDbConnection? conn = null;
            conn = new OracleConnection(connectionString);
            //conn.Open();//dapper自动管理conn链接
            return conn;
        }


    }
}
