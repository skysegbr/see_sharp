using Oracle.DataAccess.Client;
using System;

namespace DBUtil
{
    public class DBConnection
    {
        public static OracleDataReader Execute(string queryString)
        {
            string connectionString = "User Id=C##tux;Password=tux;Data Source=localhost:1521/ORCLCDB";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        connection.Open();
                        cmd.CommandText = queryString;
                        OracleDataReader reader = cmd.ExecuteReader();
                        return reader;

                        //DataTable schemaTable = reader.GetSchemaTable();

                        // while (reader.Read())
                        // {
                        //     Console.WriteLine(reader["NOME_PAIS"]);
                        // }

                        //foreach (DbDataRecord s in reader)
                        //{
                        //    string val = s.GetString(0);
                        //    Console.WriteLine(val);
                        //}

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        return null;
                    }
                }
            }
        }
        //public void Connect()
        //{
        //    string conString = "User Id=C##tux;Password=tux;Data Source=localhost:1521/ORCLCDB";
        //}
    }
}

