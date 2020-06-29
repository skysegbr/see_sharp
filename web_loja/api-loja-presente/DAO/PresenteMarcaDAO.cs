using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using api_loja;
using api_loja_presente.Model;
using Oracle.ManagedDataAccess.Client;

namespace api_loja_presente.DAO
{
    public class PresenteMarcaDAO : IPresenteMarcaDAO
    {
        public List<PresenteMarcaEntity> ListarMarcaPresente()
        {
            ConnectionFactory connection = new ConnectionFactory();
            var con = connection.GetConnection();
            try
            {
                con.Open();
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
            }
            OracleCommand cmd = new OracleCommand("LOJA_REGRAS.LISTAR_MARCA_PRESENTE", con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter P_MARCA = new OracleParameter();
            P_MARCA.OracleDbType = OracleDbType.RefCursor;
            P_MARCA.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P_MARCA);
            
            OracleDataReader reader;
            reader = cmd.ExecuteReader();

            List<PresenteMarcaEntity> listaMarca = new List<PresenteMarcaEntity>();
            foreach (DbDataRecord s in reader)
            {
                var marca = new PresenteMarcaEntity();

                marca.CodMarca = s.GetInt32(0);
                marca.MarcaDesc = s.GetString(1);
                listaMarca.Add(marca);
            }
            reader.Dispose();
            con.Dispose();

            return listaMarca;
        }
    }
}