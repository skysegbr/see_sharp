using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using api_loja;
using api_loja_presente.Model;
using Oracle.ManagedDataAccess.Client;

namespace api_loja_presente.DAO
{
    public class PresenteFornecedorDAO : IPresenteFornecedorDAO
    {
        public List<PresenteFornecedorEntity> ListarFoenecedorPresente()
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
            OracleCommand cmd = new OracleCommand("LOJA_REGRAS.LISTAR_FORN_PRESENTE", con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter P_FORNECEDOR = new OracleParameter();
            P_FORNECEDOR.OracleDbType = OracleDbType.RefCursor;
            P_FORNECEDOR.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P_FORNECEDOR);
            
            OracleDataReader reader;
            reader = cmd.ExecuteReader();

            List<PresenteFornecedorEntity> listaFonr = new List<PresenteFornecedorEntity>();
            foreach (DbDataRecord s in reader)
            {
                var forn = new PresenteFornecedorEntity();

                forn.CodFornecedor = s.GetInt32(0);
                forn.NomeFornecedor = s.GetString(1);
                listaFonr.Add(forn);
            }
            reader.Dispose();
            con.Dispose();

            return listaFonr;
        }
    }
}