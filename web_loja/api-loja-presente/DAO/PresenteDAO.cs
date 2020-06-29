using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using api_loja;
using api_loja_presente.Model;
using Oracle.ManagedDataAccess.Client;

namespace api_loja_presente.DAO
{
    public class PresenteDAO : IPresenteDAO
    {
        public void CadPresente(PresenteEntity presente)
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
            OracleCommand cmd = new OracleCommand("LOJA_REGRAS.REGISTRA_PRESENTE", con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter preseteDesc = new OracleParameter("P_PRESENTE_DESC", OracleDbType.Varchar2);
            preseteDesc.Direction = ParameterDirection.Input;
            preseteDesc.Value = presente.descPresente;
            cmd.Parameters.Add(preseteDesc);

            OracleParameter presenteTipo = new OracleParameter("P_COD_TIPO", OracleDbType.Int32);
            presenteTipo.Direction = ParameterDirection.Input;
            presenteTipo.Value = presente.codTipo; 
            cmd.Parameters.Add(presenteTipo);

            OracleParameter presenteMarca = new OracleParameter("P_COD_MARCA", OracleDbType.Int32);
            presenteMarca.Direction = ParameterDirection.Input;
            presenteMarca.Value = presente.codMarca;
            cmd.Parameters.Add(presenteMarca);

            OracleParameter presenteFinalidade = new OracleParameter("P_COD_FINALIDADE", OracleDbType.Int32);
            presenteFinalidade.Direction = ParameterDirection.Input;
            presenteFinalidade.Value = presente.codFinalidade;
            cmd.Parameters.Add(presenteFinalidade);

            OracleParameter presenteCor = new OracleParameter("P_PRESENTE_COR", OracleDbType.Varchar2);
            presenteCor.Direction = ParameterDirection.Input;
            presenteCor.Value = presente.corPresente;
            cmd.Parameters.Add(presenteCor);

            OracleParameter presenteTamanho = new OracleParameter("P_PRESENTE_TAMANHO", OracleDbType.Varchar2);
            presenteTamanho.Direction = ParameterDirection.Input;
            presenteTamanho.Value = presente.tamanhoPresente;
            cmd.Parameters.Add(presenteTamanho);

            OracleParameter presentePreco = new OracleParameter("P_PRESENTE_PRECO", OracleDbType.Decimal);
            presentePreco.Direction = ParameterDirection.Input;
            presentePreco.Value = presente.precoPresente;
            cmd.Parameters.Add(presentePreco);

            OracleParameter presenteForn = new OracleParameter("P_COD_FORNECEDOR", OracleDbType.Int32);
            presenteForn.Direction = ParameterDirection.Input;
            presenteForn.Value = presente.codFornecedor;
            cmd.Parameters.Add(presenteForn);

            cmd.ExecuteNonQuery();

        }

        public List<PresenteEntity> ListarPresente()
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
            OracleCommand cmd = new OracleCommand("LOJA_REGRAS.RET_PRESENTE", con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter preseteCod = new OracleParameter("P_COD_PRESENTE", OracleDbType.Int32);
            preseteCod.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(preseteCod);

            OracleParameter preseteRef = new OracleParameter("P_PRESENTE", OracleDbType.RefCursor);
            preseteRef.Direction = ParameterDirection.Output;
            preseteCod.Value = 0;
            cmd.Parameters.Add(preseteRef);

            OracleDataReader reader;
            reader = cmd.ExecuteReader();

            List<PresenteEntity> listaPresente = new List<PresenteEntity>();
            foreach (DbDataRecord s in reader)
            {
                var presesnte = new PresenteEntity();

                presesnte.codPresente = s.GetInt32(0);
                presesnte.descPresente = s.GetString(1);
                presesnte.descMarca = s.GetString(2);
                presesnte.corPresente = s.GetString(3);
                presesnte.tamanhoPresente = s.GetString(4);
                presesnte.precoPresente = s.GetDouble(5);
                presesnte.codTipo = s.GetInt32(6);
                listaPresente.Add(presesnte);
            }
            reader.Dispose();
            con.Dispose();

            return listaPresente;
        }
    }
}