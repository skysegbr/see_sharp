using Microsoft.Data.Sqlite;
using System;

namespace DB
{
    public class ConnectionSQLite
    {
        private static SqliteConnection sQliteConnection;

        private static SqliteConnection DbConnection()
        {
            sqliteConnection = new SqliteConnection(@"Data Source=c:\tmp\db_cliente.db");
            //sqliteConnection.O

        }
    }
}
