using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using APIautorizador.Entity;
using Oracle.ManagedDataAccess.Client;

namespace APIautorizador.DAO
{
    public class PlanoSaudeDAO : IPlanoSaudeDAO
    {
        public List<PlanoSaudeEntity> Listar(string nome)
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

            OracleCommand cmd = new OracleCommand("AUTORIZADOR_REGRAS.RET_PLAS", con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter p_plas = new OracleParameter();
            p_plas.OracleDbType = OracleDbType.RefCursor;
            p_plas.Direction = ParameterDirection.Output;
            cmd.Parameters.Add("P_COD_PLAS", OracleDbType.Int16).Value = 0;
            cmd.Parameters.Add("P_NOME_PLAS", OracleDbType.Varchar2).Value = "sulamerica";
            cmd.Parameters.Add(p_plas);
            OracleDataReader reader;
            reader = cmd.ExecuteReader();

            List<PlanoSaudeEntity> listaPlanos = new List<PlanoSaudeEntity>();
            foreach (DbDataRecord s in reader)
            {
                var plano = new PlanoSaudeEntity();

                plano.CodPlas = s.GetInt32(0);
                plano.CnpjPlas = s.GetInt64(1);
                plano.NomePlas = s.GetString(2);
                listaPlanos.Add(plano);
            }
            reader.Dispose();
            con.Dispose();

            return listaPlanos;
        }
    }
}