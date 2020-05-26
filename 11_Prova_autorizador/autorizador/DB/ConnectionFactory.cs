using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUtil
{
    public class ConnectionFactory
    {
        public OracleConnection GetConnection()
        {
            OracleConnection con = new OracleConnection("User Id=C##tux;Password=tux;Data Source=localhost:1521/ORCLCDB");
            return con;
        }
    }
}
