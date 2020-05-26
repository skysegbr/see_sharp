using System;
using System.Collections.Generic;
using System.Data.Common;
using _01_conect_oracle_database.Entitys;
using Oracle.ManagedDataAccess.Client;

namespace _01_conect_oracle_database
{
    class Program
    {
        public static List<PlanoSaudeEntity> Execute(string queryString, string connectionString)
        {
           var list = new List<PlanoSaudeEntity>();
           //var plano = new PlanoSaudeEntity();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        OracleDataReader reader;
                        connection.Open();
                        cmd.CommandText = queryString;
                        reader = cmd.ExecuteReader();
                        
                        foreach (DbDataRecord s in reader)
                        {
                            //string val = s.GetString(0);
                            //Console.WriteLine(val);
                            var plano = new PlanoSaudeEntity();
                            plano.NomePlas = s.GetString(0);
                            list.Add(plano);
                        }
                        return list;


                        //DataTable schemaTable = reader.GetSchemaTable();

                        // while (reader.Read())
                        // {
                        //     Console.WriteLine(reader["NOME_PAIS"]);
                        // }



                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        return null;
                    }

                }

            }
        }
    //     static void Main(string[] args)
    //     {

    //         var list = new List<PlanoSaudeEntity>();
    //         var plano = new Entitys.PlanoSaudeEntity();
    //         string conString = "User Id=C##tux;Password=tux;Data Source=localhost:1521/ORCLCDB";

    //         string sql = "SELECT PS.NOME_PLAS FROM TB_PLANO_SAUDE PS";
    //         list = Execute(sql, conString);
    
    //         foreach (PlanoSaudeEntity p in list)
    //         {
    //             string val = p.NomePlas;
    //             Console.WriteLine(val);
    //         }

    //         Console.WriteLine("Hello World!");
    //     }
    }
}
