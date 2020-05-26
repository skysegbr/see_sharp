using System;
using Oracle.ManagedDataAccess.Client;

namespace APIAutorizador
{
    class ConnectionFactory
    {
        public OracleConnection GetConnection()
        {
            OracleConnection con = new OracleConnection("User Id=C##tux;Password=tux;Data Source=localhost:1521/ORCLCDB");
            return con;
        }
    }
}