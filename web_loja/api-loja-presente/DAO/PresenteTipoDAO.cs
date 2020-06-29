using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using api_loja;
using api_loja_presente.Model;
using Oracle.ManagedDataAccess.Client;

namespace api_loja_presente.DAO
{
    public class PresenteTipoDAO : IPresenteTipoDAO
    {   
        public List<PresenteTipoEntity> ListarTipoPresente()
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
            OracleCommand cmd = new OracleCommand("LOJA_REGRAS.LISTAR_TIPO_PRESENTE", con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter P_TIPO_PRODUTO = new OracleParameter();
            P_TIPO_PRODUTO.OracleDbType = OracleDbType.RefCursor;
            P_TIPO_PRODUTO.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P_TIPO_PRODUTO);
            
            OracleDataReader reader;
            reader = cmd.ExecuteReader();

            List<PresenteTipoEntity> listaTipo = new List<PresenteTipoEntity>();
            foreach (DbDataRecord s in reader)
            {
                var tipo = new PresenteTipoEntity();

                tipo.CodTipo = s.GetInt32(0);
                tipo.DescTipo = s.GetString(1);
                listaTipo.Add(tipo);
            }
            reader.Dispose();
            con.Dispose();

            return listaTipo;
        }
    }
}