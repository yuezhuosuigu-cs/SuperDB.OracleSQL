
using Oracle.ManagedDataAccess.Client;

using SuperDB.Config;

using System.Data;

namespace SuperDB.MySQL
{
    public class OracleSQLFactory : DBFactory
    {
        private IDbConnection _Connection;

        public static OracleSQLFactory Create()
        {
            return new OracleSQLFactory();
        }

        public override IDbConnection Connection
        {
            get
            {
                if (_Connection == default)
                {
                    _Connection = new OracleConnection(DBConfig.ConnectionString);
                }
                if (_Connection.State != ConnectionState.Open)
                {
                    _Connection.Open();
                }
                return _Connection;
            }
        }
    }
}
