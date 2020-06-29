using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using api_loja;
using api_loja_presente.Model;
using Oracle.ManagedDataAccess.Client;

namespace api_loja_presente.DAO
{
    public class PresenteFinalidadeDAO : IPresenteFinalidadeDAO

    {
        public List<PresenteFinalidadeEntity> ListarFinalidadePresente()
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
            OracleCommand cmd = new OracleCommand("LOJA_REGRAS.LISTAR_FINALIDADE_PRESENTE", con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter P_FINALIDADE = new OracleParameter();
            P_FINALIDADE.OracleDbType = OracleDbType.RefCursor;
            P_FINALIDADE.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P_FINALIDADE);
            
            OracleDataReader reader;
            reader = cmd.ExecuteReader();

            List<PresenteFinalidadeEntity> listaFinalidade = new List<PresenteFinalidadeEntity>();
            foreach (DbDataRecord s in reader)
            {
                var finalidade = new PresenteFinalidadeEntity();

                finalidade.CodFinalidade = s.GetInt32(0);
                finalidade.DescFinalidade = s.GetString(1);
                listaFinalidade.Add(finalidade);
            }
            reader.Dispose();
            con.Dispose();

            return listaFinalidade;
        }
    }
}